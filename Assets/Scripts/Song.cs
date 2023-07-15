using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Notes
{

    public static float Silence = 0.0f;
    public static float C2 = 65.4064f;
    public static float Cs2 = 69.2957f;
    public static float D2 = 73.4162f;
    public static float Ds2 = 77.78175f;
    public static float E2 = 82.4069f;
    public static float F2 = 87.3071f;
    public static float Fs2 = 92.4986f;
    public static float G2 = 97.9989f;
    public static float Gs2 = 103.826f;
    public static float A2 = 110.000f;
    public static float As2 = 116.541f;
    public static float B2 = 123.471f;
    public static float C3 = 130.813f;
    public static float Cs3 = 138.591f;
    public static float D3 = 146.832f;
    public static float Ds3 = 155.5635f;
    public static float E3 = 164.814f;
    public static float F3 = 174.614f;
    public static float Fs3 = 184.997f;
    public static float G3 = 195.998f;
    public static float Gs3 = 207.652f;
    public static float A3 = 220.000f;
    public static float As3 = 233.082f;
    public static float B3 = 246.942f;
    public static float C4 = 261.626f;
    public static float Cs4 = 277.183f;
    public static float D4 = 293.665f;
    public static float Ds4 = 311.1270f;
    public static float E4 = 329.628f;
    public static float F4 = 349.228f;
    public static float Fs4 = 369.994f;
    public static float G4 = 391.995f;
    public static float Gs4 = 415.305f;
    public static float A4 = 440f;
    public static float As4 = 466.164f;
    public static float B4 = 493.88f;
    public static float C5 = 523.25f;
    public static float Cs5 = 554.365f;
    public static float D5 = 587.33f;
    public static float Ds5 = 622.254f;
    public static float E5 = 659.25f;
    public static float F5 = 698.46f;
    public static float Fs5 = 739.989f;
    public static float G5 = 783.99f;
    public static float Gs5 = 830.609f;
    public static float A5 = 880.000f;
    public static float As5 = 932.328f;
    public static float B5 = 987.767f;
    public static float C6 = 1046.50f;
    public static float Cs6 = 1108.73f;
    public static float D6 = 1174.66f;
    public static float Ds6 = 1244.51f;
    public static float E6 = 1318.51f;
    public static float F6 = 1396.91f;
    public static float Fs6 = 1479.98f;
    public static float G6 = 1567.98f;
    public static float Gs6 = 1661.22f;
    public static float A6 = 1760.00f;
    public static float B6 = 1975.53f;
}
public class PlayNote
{
    public float note;
    public float duration;
    public float time;
    private readonly float beatLenght = 1f; // 120 bpm
    public PlayNote(float note, float time, float duration)
    {

        this.note = note;
        this.duration = duration;
        this.time = time;
    }
}

public class Song
{
    public int channel;
    public int index;
    public List<PlayNote> notes;
    public float thereminVolume = 1.0f;

    public Song(int channel, int index, List<PlayNote> notes, float thereminVolume = 1.0f)
    {
        this.channel = channel;
        this.index = index;
        this.notes = notes;
        this.thereminVolume = thereminVolume;
    }
}
