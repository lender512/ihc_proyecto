import json
import os
import sys
import pandas as pd

def apply_pitch_bend(note, pitch_bend):
    note_mapping = {
        'C': 0, 'Cs': 1, 'Db': 1, 'D': 2, 'Ds': 3, 'Eb': 3,
        'E': 4, 'F': 5, 'Fs': 6, 'Gb': 6, 'G': 7, 'Gs': 8,
        'Ab': 8, 'A': 9, 'As': 10, 'Bb': 10, 'B': 11
    }

    note_name, octave = note[:-1], int(note[-1])

    note_number = (octave + 1) * 12 + note_mapping[note_name]

    pitch_bend_range = 4  # Adjust this value based on your desired pitch bend range

    pitch_bend_amount = pitch_bend * pitch_bend_range

    new_note_number = note_number + pitch_bend_amount

    new_octave = int(new_note_number // 12 - 1)
    new_note_name = list(note_mapping.keys())[list((note_mapping.values())).index(int(new_note_number % 12))]

    new_note = new_note_name + str(new_octave)

    return new_note

#https://tonejs.github.io/Midi/
a = json.load(open('midi.json'))


outputPath = "C:/Users/lucho/IHC/Assets/Songs"

for i, key in enumerate(a["tracks"]):
    try:
        instrument = key["instrument"]["name"]
        notes = len(key["notes"])
        bends = len(key["pitchBends"])
        if notes > 0:
            print(f"{i} {instrument} {notes} {bends}")
    except:
        pass

# a["tracks"][channel].keys()
# a["tracks"][channel]["pitchBends"][1]

song = "NeverGonnaGiveYouUp"
channel = 26
songIndex = 26

#store the json
with open('midir.json', 'w') as outfile:
    #store dic as json file
    json.dump(a, outfile)


df = pd.DataFrame(a["tracks"][channel]["notes"])

df["name"] = df["name"].str.replace("#", "s")

df["name"] = "Notes." + df["name"]



#if same time, keep hioher note
df = df.sort_values(by=['time', 'name'], ascending=False)
df = df.drop_duplicates(subset=['time'], keep='first')
df = df.sort_values(by=['time'])

df["name"] = df["name"].str.replace("7", "6")

# fix bends
for index in range(len(df)):
    row = df.iloc[index]
    for bend in a["tracks"][channel]["pitchBends"]:
        time = bend["time"]
        if row["time"] + row["duration"] > time and row["time"] < time:
            note = row["name"].split(".")[1]
            duration = row["duration"] - (time - row["time"])
            # df._append({"time": time, "name": "Notes." + apply_pitch_bend(note, bend["value"]), "duration": duration}, ignore_index=True)
            new_note = "Notes." + apply_pitch_bend(note, bend["value"])
            new_row = {"time": time, "name": new_note, "duration": duration}
            df = df._append(new_row, ignore_index=True)
            df.at[index, "duration"] = time - row["time"]
            index -= 1
            break
df = df.sort_values(by=['time'])
PlayNoteList = ""



for index, row in df.iterrows():
    # if index == len(df) - 1:
    #     break
    # next_row = df.iloc[index + 1]
    # if row["time"] + row["duration"] > next_row["time"]:
    #     row["duration"] = next_row["time"] - row["time"] - 0.01
    PlayNoteList += f"          new PlayNote({row['name']}, {row['time']}f, {row['duration']}f),\n"

#str to file 


str = f"""
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class {song} : SongScript
{{
    public override Song GetSong()
    {{
        return new Song(
        {channel},
        {songIndex},
        new List<PlayNote> 
        {{
{PlayNoteList}
        }}
        );
    }}
}}
"""
#joined path
pat = os.path.join(outputPath, song + ".cs")
with open(pat  , 'w') as outfile:
    outfile.write(str)

#create empty gameObj