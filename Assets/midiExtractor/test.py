#parse midi.json
#parse midi.json

import json
import os
import sys
import pandas as pd

#https://tonejs.github.io/Midi/
a = json.load(open('midi.json'))


#store the json
with open('midir.json', 'w') as outfile:
    #store dic as json file
    json.dump(a, outfile)

channel = 2

df = pd.DataFrame(a["tracks"][channel]["notes"])

df["name"] = df["name"].str.replace("#", "s")

df["name"] = "Notes." + df["name"]



#if same time, keep hioher note
df = df.sort_values(by=['time', 'name'], ascending=False)
df = df.drop_duplicates(subset=['time'], keep='first')
df = df.sort_values(by=['time'])


str = "private List<PlayNote> song = new List<PlayNote> {"
for index, row in df.iterrows():
    next_row = df.iloc[index + 1]
    if row["time"] + row["duration"] > next_row["time"]:
        row["duration"] = next_row["time"] - row["time"] - 0.01
    str += f"   new PlayNote({row['name']}, {row['time']}f, {row['duration']}f),\n"
str += "};"

#str to file 
with open('song.cs', 'w') as outfile:
    outfile.write(str)

