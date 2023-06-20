using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote {
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

public static class Notes 
{

    public static float Silence = 0.0f;
    public static float C2 = 65.4064f;
    public static float Cs2 = 69.2957f;
    public static float D2 = 73.4162f;
    public static float E2 = 82.4069f;
    public static float F2 = 87.3071f;
    public static float F2s = 92.4986f;
    public static float G2 = 97.9989f;
    public static float Gs2 = 103.826f;
    public static float A2 = 110.000f;
    public static float As2 = 116.541f;
    public static float B2 = 123.471f;
    public static float C3 = 130.813f;
    public static float Cs3 = 138.591f;
    public static float D3 = 146.832f;
    public static float E3 = 164.814f;
    public static float F3 = 174.614f;
    public static float F3s = 184.997f;
    public static float G3 = 195.998f;
    public static float Gs3 = 207.652f;
    public static float A3 = 220.000f;
    public static float As3 = 466.164f;
    public static float B3 = 246.942f;
    public static float C4 = 261.626f;
    public static float Cs4 = 277.183f;
    public static float D4 = 293.665f;
    public static float E4 = 329.628f;
    public static float F4 = 349.228f;
    public static float F4s = 369.994f;
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
}

public class NoteGeneratorLogic : MonoBehaviour
{
    public float maxTime = 1;
    private float initTime = 0;
    public GameObject note;
    public GameObject endCollider;
    private List<GameObject> notes = new List<GameObject>();

    private readonly float lowerBound = 65;
    private readonly float upperBound = 1568f;
    private readonly float offset = 0.0f;

    public MidiPlayerTK.MidiFilePlayer midiPlayer;

    private float factor = 2;

    //private List<PlayNote> song = new List<PlayNote> {
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.FA4, 1f),
    //    new PlayNote(Notes.SOL4, 1f),

    //    new PlayNote(Notes.SOL4, 1f),
    //    new PlayNote(Notes.FA4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.RE4, 1f),

    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.MI4, 1f),

    //    new PlayNote(Notes.MI4, 1.5f),
    //    new PlayNote(Notes.RE4, 0.5f),
    //    new PlayNote(Notes.RE4, 2f),

    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.FA4, 1f),
    //    new PlayNote(Notes.SOL4, 1f),

    //    new PlayNote(Notes.SOL4, 1f),
    //    new PlayNote(Notes.FA4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.RE4, 1f),

    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.MI4, 1f),

    //    new PlayNote(Notes.RE4, 1.5f),
    //    new PlayNote(Notes.DO4, 0.5f),
    //    new PlayNote(Notes.DO4, 2f),

    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.DO4, 1f),

    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.MI4, 0.5f),
    //    new PlayNote(Notes.FA4, 0.5f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.DO4, 1f),

    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.MI4, 0.5f),
    //    new PlayNote(Notes.FA4, 0.5f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.RE4, 1f),

    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.SOL4, 1f),
    //    new PlayNote(Notes.MI4, 1f),

    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.FA4, 1f),
    //    new PlayNote(Notes.SOL4, 1f),

    //    new PlayNote(Notes.SOL4, 1f),
    //    new PlayNote(Notes.FA4, 1f),
    //    new PlayNote(Notes.MI4, 1f),
    //    new PlayNote(Notes.RE4, 1f),

    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.DO4, 1f),
    //    new PlayNote(Notes.RE4, 1f),
    //    new PlayNote(Notes.MI4, 1f),

    //    new PlayNote(Notes.RE4, 1.5f),
    //    new PlayNote(Notes.DO4, 0.5f),
    //    new PlayNote(Notes.DO4, 2f),

    //};

    //private List<PlayNote> song = new List<PlayNote> {
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.DO4,     .25f),
    //    new PlayNote(Notes.DO4,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.SI3,     .25f),
    //    new PlayNote(Notes.SI3,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.LA3s,     .25f),
    //    new PlayNote(Notes.LA3s,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.DO4,     .25f),
    //    new PlayNote(Notes.DO4,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.SI3,     .25f),
    //    new PlayNote(Notes.SI3,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),

    //    new PlayNote(Notes.LA3s,     .25f),
    //    new PlayNote(Notes.LA3s,     .25f),
    //    new PlayNote(Notes.RE5,     .75f),
    //    new PlayNote(Notes.LA4,     .75f),
    //    new PlayNote(Notes.Silence, .25f),
    //    new PlayNote(Notes.SOL4s,   .75f),
    //    new PlayNote(Notes.SOL4,    .75f),
    //    new PlayNote(Notes.FA4,     .5f),
    //    new PlayNote(Notes.RE4,     .25f),
    //    new PlayNote(Notes.FA4,     .25f),
    //    new PlayNote(Notes.SOL4,    .25f),
    //};

    private List<PlayNote> song = new List<PlayNote> {   new PlayNote(Notes.D4, 0.0f, 0.130435f),
   new PlayNote(Notes.D4, 0.130435f, 0.130435f),
   new PlayNote(Notes.D5, 0.26087f, 0.26087f),
   new PlayNote(Notes.A4, 0.52174f, 0.391305f),
   new PlayNote(Notes.Gs4, 0.913045f, 0.26087000000000005f),
   new PlayNote(Notes.G4, 1.173915f, 0.26086999999999994f),
   new PlayNote(Notes.F4, 1.434785f, 0.26086999999999994f),
   new PlayNote(Notes.D4, 1.695655f, 0.13043500000000008f),
   new PlayNote(Notes.F4, 1.82609f, 0.13043499999999986f),
   new PlayNote(Notes.G4, 1.9565249999999998f, 0.13043500000000008f),
   new PlayNote(Notes.C4, 2.08696f, 0.13043499999999986f),
   new PlayNote(Notes.C4, 2.217395f, 0.1304350000000003f),
   new PlayNote(Notes.D5, 2.34783f, 0.2608699999999997f),
   new PlayNote(Notes.A4, 2.6087f, 0.391305f),
   new PlayNote(Notes.Gs4, 3.000005f, 0.26087000000000016f),
   new PlayNote(Notes.G4, 3.260875f, 0.2608699999999997f),
   new PlayNote(Notes.F4, 3.5217449999999997f, 0.26087000000000016f),
   new PlayNote(Notes.D4, 3.782615f, 0.13043499999999986f),
   new PlayNote(Notes.F4, 3.9130499999999997f, 0.13043499999999986f),
   new PlayNote(Notes.G4, 4.0434849999999996f, 0.1304350000000003f),
   new PlayNote(Notes.B3, 4.17392f, 0.1304350000000003f),
   new PlayNote(Notes.B3, 4.304355f, 0.1304349999999994f),
   new PlayNote(Notes.D5, 4.43479f, 0.2608700000000006f),
   new PlayNote(Notes.A4, 4.69566f, 0.391305f),
   new PlayNote(Notes.Gs4, 5.086965f, 0.2608699999999997f),
   new PlayNote(Notes.G4, 5.347835f, 0.2608699999999997f),
   new PlayNote(Notes.F4, 5.608705f, 0.2608700000000006f),
   new PlayNote(Notes.D4, 5.869575f, 0.1304349999999994f),
   new PlayNote(Notes.F4, 6.00001f, 0.1304350000000003f),
   new PlayNote(Notes.G4, 6.130445f, 0.1304350000000003f),
   new PlayNote(Notes.As3, 6.26088f, 0.1304349999999994f),
   new PlayNote(Notes.As3, 6.391315f, 0.1304350000000003f),
   new PlayNote(Notes.D5, 6.52175f, 0.2608699999999997f),
   new PlayNote(Notes.A4, 6.78262f, 0.391305f),
   new PlayNote(Notes.Gs4, 7.173925f, 0.2608699999999997f),
   new PlayNote(Notes.G4, 7.434794999999999f, 0.2608700000000006f),
   new PlayNote(Notes.F4, 7.695665f, 0.2608699999999997f),
   new PlayNote(Notes.D4, 7.956535f, 0.1304349999999994f),
   new PlayNote(Notes.F4, 8.086969999999999f, 0.1304350000000003f),
   new PlayNote(Notes.G4, 8.217405f, 0.1304350000000003f),
   new PlayNote(Notes.D4, 8.34784f, 0.1304350000000003f),
   new PlayNote(Notes.D4, 8.478275f, 0.1304350000000003f),
   new PlayNote(Notes.D5, 8.60871f, 0.2608699999999988f),
   new PlayNote(Notes.A4, 8.86958f, 0.3913050000000009f),
   new PlayNote(Notes.Gs4, 9.260885f, 0.2608699999999988f),
   new PlayNote(Notes.G4, 9.521754999999999f, 0.2608700000000006f),
   new PlayNote(Notes.F4, 9.782625f, 0.2608700000000006f),
   new PlayNote(Notes.D4, 10.043495f, 0.1304350000000003f),
   new PlayNote(Notes.F4, 10.17393f, 0.13043499999999852f),
   new PlayNote(Notes.G4, 10.304364999999999f, 0.1304350000000003f),
   new PlayNote(Notes.C4, 10.4348f, 0.1304350000000003f),
   new PlayNote(Notes.C4, 10.565235f, 0.1304350000000003f),
   new PlayNote(Notes.D5, 10.69567f, 0.2608700000000006f),
   new PlayNote(Notes.A4, 10.95654f, 0.3913049999999991f),
   new PlayNote(Notes.Gs4, 11.347845f, 0.2608700000000006f),
   new PlayNote(Notes.G4, 11.608715f, 0.2608699999999988f),
   new PlayNote(Notes.F4, 11.869584999999999f, 0.2608700000000006f),
   new PlayNote(Notes.D4, 12.130455f, 0.1304350000000003f),
   new PlayNote(Notes.F4, 12.26089f, 0.1304350000000003f),
   new PlayNote(Notes.G4, 12.391325f, 0.1304350000000003f),
   new PlayNote(Notes.B3, 12.52176f, 0.13043499999999852f),
   new PlayNote(Notes.B3, 12.652194999999999f, 0.1304350000000003f),
   new PlayNote(Notes.D5, 12.78263f, 0.2608700000000006f),
   new PlayNote(Notes.A4, 13.0435f, 0.3913049999999991f),
   new PlayNote(Notes.Gs4, 13.434804999999999f, 0.2608700000000006f),
   new PlayNote(Notes.G4, 13.695675f, 0.2608700000000006f),
   new PlayNote(Notes.F4, 13.956545f, 0.2608699999999988f),
   new PlayNote(Notes.D4, 14.217414999999999f, 0.1304350000000003f),
   new PlayNote(Notes.F4, 14.34785f, 0.1304350000000003f),
   new PlayNote(Notes.G4, 14.478285f, 0.1304350000000003f),
   new PlayNote(Notes.As3, 14.60872f, 0.1304350000000003f),
   new PlayNote(Notes.As3, 14.739155f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 14.869589999999999f, 0.2608700000000006f),
   new PlayNote(Notes.A4, 15.13046f, 0.3913050000000009f),
   new PlayNote(Notes.Gs4, 15.521765f, 0.2608699999999988f),
   new PlayNote(Notes.G4, 15.782634999999999f, 0.2608700000000006f),
   new PlayNote(Notes.F4, 16.043505f, 0.2608700000000006f),
   new PlayNote(Notes.D4, 16.304375f, 0.13043499999999852f),
   new PlayNote(Notes.F4, 16.43481f, 0.13043500000000208f),
   new PlayNote(Notes.G4, 16.565245f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 16.69568f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 16.826114999999998f, 0.13043500000000208f),
   new PlayNote(Notes.D6, 16.95655f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 17.21742f, 0.3913049999999991f),
   new PlayNote(Notes.Gs5, 17.608725f, 0.2608700000000006f),
   new PlayNote(Notes.G5, 17.869595f, 0.2608700000000006f),
   new PlayNote(Notes.F5, 18.130465f, 0.26086999999999705f),
   new PlayNote(Notes.D5, 18.391334999999998f, 0.13043500000000208f),
   new PlayNote(Notes.F5, 18.52177f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 18.652205f, 0.13043500000000208f),
   new PlayNote(Notes.C5, 18.78264f, 0.13043499999999852f),
   new PlayNote(Notes.C5, 18.913075f, 0.13043499999999852f),
   new PlayNote(Notes.D6, 19.043509999999998f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 19.30438f, 0.3913050000000027f),
   new PlayNote(Notes.Gs5, 19.695685f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 19.956554999999998f, 0.2608700000000006f),
   new PlayNote(Notes.F5, 20.217425f, 0.2608700000000006f),
   new PlayNote(Notes.D5, 20.478295f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 20.608729999999998f, 0.13043500000000208f),
   new PlayNote(Notes.G5, 20.739165f, 0.13043499999999852f),
   new PlayNote(Notes.B4, 20.8696f, 0.13043500000000208f),
   new PlayNote(Notes.B4, 21.000035f, 0.13043499999999852f),
   new PlayNote(Notes.D6, 21.13047f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 21.39134f, 0.3913049999999991f),
   new PlayNote(Notes.Gs5, 21.782645f, 0.2608700000000006f),
   new PlayNote(Notes.G5, 22.043515f, 0.2608700000000006f),
   new PlayNote(Notes.F5, 22.304385f, 0.2608700000000006f),
   new PlayNote(Notes.D5, 22.565255f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 22.69569f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 22.826124999999998f, 0.13043500000000208f),
   new PlayNote(Notes.As4, 22.95656f, 0.13043499999999852f),
   new PlayNote(Notes.As4, 23.086994999999998f, 0.13043500000000208f),
   new PlayNote(Notes.D6, 23.21743f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 23.4783f, 0.3913049999999991f),
   new PlayNote(Notes.Gs5, 23.869605f, 0.2608700000000006f),
   new PlayNote(Notes.G5, 24.130475f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 24.391344999999998f, 0.2608700000000006f),
   new PlayNote(Notes.D5, 24.652214999999998f, 0.13043500000000208f),
   new PlayNote(Notes.F5, 24.78265f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 24.913085f, 0.13043500000000208f),
   new PlayNote(Notes.D5, 25.04352f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 25.173955f, 0.13043499999999852f),
   new PlayNote(Notes.D6, 25.304389999999998f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 25.56526f, 0.3913049999999991f),
   new PlayNote(Notes.Gs5, 25.956564999999998f, 0.2608700000000006f),
   new PlayNote(Notes.G5, 26.217435f, 0.2608700000000006f),
   new PlayNote(Notes.F5, 26.478305f, 0.2608700000000006f),
   new PlayNote(Notes.D5, 26.739175f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 26.869609999999998f, 0.13043500000000208f),
   new PlayNote(Notes.G5, 27.000045f, 0.13043499999999852f),
   new PlayNote(Notes.C5, 27.13048f, 0.13043500000000208f),
   new PlayNote(Notes.C5, 27.260915f, 0.13043499999999852f),
   new PlayNote(Notes.D6, 27.39135f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 27.65222f, 0.3913049999999991f),
   new PlayNote(Notes.Gs5, 28.043525f, 0.2608700000000006f),
   new PlayNote(Notes.G5, 28.304395f, 0.2608700000000006f),
   new PlayNote(Notes.F5, 28.565265f, 0.2608700000000006f),
   new PlayNote(Notes.D5, 28.826135f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 28.95657f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 29.087004999999998f, 0.13043500000000208f),
   new PlayNote(Notes.B4, 29.21744f, 0.13043499999999852f),
   new PlayNote(Notes.B4, 29.347875f, 0.13043500000000208f),
   new PlayNote(Notes.D6, 29.47831f, 0.26086999999999705f),
   new PlayNote(Notes.A5, 29.739179999999998f, 0.3913050000000027f),
   new PlayNote(Notes.Gs5, 30.130485f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 30.391354999999997f, 0.2608700000000006f),
   new PlayNote(Notes.F5, 30.652224999999998f, 0.2608700000000006f),
   new PlayNote(Notes.D5, 30.913095f, 0.13043500000000208f),
   new PlayNote(Notes.F5, 31.04353f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 31.173965f, 0.13043499999999852f),
   new PlayNote(Notes.As4, 31.304399999999998f, 0.13043500000000208f),
   new PlayNote(Notes.As4, 31.434835f, 0.13043499999999852f),
   new PlayNote(Notes.D6, 31.565269999999998f, 0.2608700000000006f),
   new PlayNote(Notes.A5, 31.82614f, 0.3913049999999991f),
   new PlayNote(Notes.Gs5, 32.217445f, 0.26087000000000415f),
   new PlayNote(Notes.G5, 32.478315f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 32.739185f, 0.26086999999999705f),
   new PlayNote(Notes.D5, 33.000054999999996f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 33.13049f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 33.260925f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 33.39136f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 33.652229999999996f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 33.782665f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 34.043535f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 34.304404999999996f, 0.26087000000000415f),
   new PlayNote(Notes.D5, 34.565275f, 0.26086999999999705f),
   new PlayNote(Notes.D5, 34.826145f, 0.6521749999999997f),
   new PlayNote(Notes.F5, 35.47832f, 0.26087000000000415f),
   new PlayNote(Notes.F5, 35.73919f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 35.869625f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 36.130494999999996f, 0.26087000000000415f),
   new PlayNote(Notes.Gs5, 36.391365f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 36.652235f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 36.782669999999996f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 36.913105f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 37.04354f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 37.173975f, 0.3913050000000027f),
   new PlayNote(Notes.F5, 37.56528f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 37.82615f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 37.956585f, 0.26087000000000415f),
   new PlayNote(Notes.G5, 38.217455f, 0.26086999999999705f),
   new PlayNote(Notes.Gs5, 38.478325f, 0.26086999999999705f),
   new PlayNote(Notes.A5, 38.739194999999995f, 0.26087000000000415f),
   new PlayNote(Notes.C6, 39.000065f, 0.13043499999999852f),
   new PlayNote(Notes.A5, 39.260934999999996f, 0.3913050000000027f),
   new PlayNote(Notes.D6, 39.65224f, 0.26086999999999705f),
   new PlayNote(Notes.D6, 39.913109999999996f, 0.26087000000000415f),
   new PlayNote(Notes.D6, 40.17398f, 0.13043499999999852f),
   new PlayNote(Notes.A5, 40.304415f, 0.13043499999999852f),
   new PlayNote(Notes.D6, 40.43485f, 0.13043499999999852f),
   new PlayNote(Notes.C6, 40.565284999999996f, 1.173915000000001f),
   new PlayNote(Notes.F5, 41.7392f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 42.00007f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 42.130505f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 42.391375f, 0.26087000000000415f),
   new PlayNote(Notes.F5, 42.652245f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 42.913115f, 0.26087000000000415f),
   new PlayNote(Notes.G5, 43.173985f, 0.6521749999999997f),
   new PlayNote(Notes.F5, 43.82616f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 44.08703f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 44.217465f, 0.26087000000000415f),
   new PlayNote(Notes.F5, 44.478335f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 44.739205f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 45.000074999999995f, 0.26087000000000415f),
   new PlayNote(Notes.D6, 45.260945f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 45.521815f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 45.652249999999995f, 0.26087000000000415f),
   new PlayNote(Notes.F5, 45.91312f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 46.173989999999996f, 0.26087000000000415f),
   new PlayNote(Notes.G5, 46.43486f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 46.69573f, 0.26087000000000415f),
   new PlayNote(Notes.F5, 46.9566f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 47.21747f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 47.478339999999996f, 0.26087000000000415f),
   new PlayNote(Notes.E5, 47.73921f, 0.26086999999999705f),
   new PlayNote(Notes.As4, 48.00008f, 0.26087000000000415f),
   new PlayNote(Notes.C5, 48.26095f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 48.391385f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 48.652255f, 0.26087000000000415f),
   new PlayNote(Notes.E5, 48.913125f, 1.173915000000001f),
   new PlayNote(Notes.F5, 51.13052f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 51.260954999999996f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 51.39139f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 51.521825f, 0.13043499999999852f),
   new PlayNote(Notes.Gs5, 51.65226f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 51.782695f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 51.913129999999995f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 52.043565f, 0.13043499999999852f),
   new PlayNote(Notes.Gs5, 52.174f, 0.06521749999999571f),
   new PlayNote(Notes.G5, 52.239217499999995f, 0.06521750000000281f),
   new PlayNote(Notes.F5, 52.304435f, 0.06521750000000281f),
   new PlayNote(Notes.D5, 52.3696525f, 0.06521749999999571f),
   new PlayNote(Notes.F5, 52.43487f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 52.69574f, 1.0434799999999953f),
   new PlayNote(Notes.Gs5, 53.869655f, 0.26086999999999705f),
   new PlayNote(Notes.A5, 54.130525f, 0.13043499999999852f),
   new PlayNote(Notes.C6, 54.26096f, 0.13043499999999852f),
   new PlayNote(Notes.A5, 54.52183f, 0.13043499999999852f),
   new PlayNote(Notes.Gs5, 54.652265f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 54.7827f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 54.913135f, 0.13043499999999852f),
   new PlayNote(Notes.D5, 55.043569999999995f, 0.13043500000000563f),
   new PlayNote(Notes.E5, 55.174005f, 0.13043499999999852f),
   new PlayNote(Notes.F5, 55.30444f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 55.56531f, 0.26087000000000415f),
   new PlayNote(Notes.A5, 55.82618f, 0.26086999999999705f),
   new PlayNote(Notes.C6, 56.08705f, 0.26086999999999705f),
   new PlayNote(Notes.Cs6, 56.347919999999995f, 0.26087000000000415f),
   new PlayNote(Notes.Gs5, 56.60879f, 0.26086999999999705f),
   new PlayNote(Notes.Gs5, 56.869659999999996f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 57.000094999999995f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 57.13053f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 57.260965f, 1.173915000000001f),
   new PlayNote(Notes.F4, 58.43488f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 58.69575f, 0.26087000000000415f),
   new PlayNote(Notes.F4, 58.95662f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 59.21749f, 0.26086999999999705f),
   new PlayNote(Notes.E5, 59.478359999999995f, 0.5217400000000012f),
   new PlayNote(Notes.D5, 60.000099999999996f, 0.5217400000000012f),
   new PlayNote(Notes.G4, 60.52184f, 0.5217400000000012f),
   new PlayNote(Notes.F5, 61.04358f, 0.5217400000000012f),
   new PlayNote(Notes.G5, 61.56532f, 0.5217400000000012f),
   new PlayNote(Notes.E5, 62.08706f, 0.5217399999999941f),
   new PlayNote(Notes.D5, 62.608799999999995f, 1.0434800000000024f),
   new PlayNote(Notes.A5, 63.65228f, 0.13043499999999852f),
   new PlayNote(Notes.Gs5, 63.782714999999996f, 0.13043499999999852f),
   new PlayNote(Notes.G5, 63.913149999999995f, 0.13043499999999852f),
   new PlayNote(Notes.Fs5, 64.043585f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 64.17402f, 0.13043500000000563f),
   new PlayNote(Notes.E5, 64.304455f, 0.13043499999999142f),
   new PlayNote(Notes.Ds5, 64.43489f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 64.565325f, 0.13043499999999142f),
   new PlayNote(Notes.Gs4, 64.69575999999999f, 0.913045000000011f),
   new PlayNote(Notes.Ds5, 65.608805f, 1.1739149999999938f),
   new PlayNote(Notes.F5, 67.8262f, 0.13043499999999142f),
   new PlayNote(Notes.D5, 67.95663499999999f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 68.08707f, 0.13043500000000563f),
   new PlayNote(Notes.G5, 68.217505f, 0.13043499999999142f),
   new PlayNote(Notes.Gs5, 68.34794f, 0.13043500000000563f),
   new PlayNote(Notes.G5, 68.478375f, 0.13043499999999142f),
   new PlayNote(Notes.F5, 68.60880999999999f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 68.739245f, 0.13043500000000563f),
   new PlayNote(Notes.Gs5, 68.86968f, 0.0652174999999886f),
   new PlayNote(Notes.G5, 68.93489749999999f, 0.06521750000000281f),
   new PlayNote(Notes.F5, 69.000115f, 0.06521750000000281f),
   new PlayNote(Notes.D5, 69.0653325f, 0.06521750000000281f),
   new PlayNote(Notes.F5, 69.13055f, 0.13043499999999142f),
   new PlayNote(Notes.G5, 69.39142f, 1.0434800000000024f),
   new PlayNote(Notes.Gs5, 70.565335f, 0.26086999999999705f),
   new PlayNote(Notes.A5, 70.826205f, 0.13043499999999142f),
   new PlayNote(Notes.C6, 70.95664f, 0.13043500000000563f),
   new PlayNote(Notes.A5, 71.21751f, 0.13043499999999142f),
   new PlayNote(Notes.Gs5, 71.347945f, 0.13043500000000563f),
   new PlayNote(Notes.G5, 71.47838f, 0.13043499999999142f),
   new PlayNote(Notes.F5, 71.60881499999999f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 71.73925f, 0.13043500000000563f),
   new PlayNote(Notes.E5, 71.869685f, 0.13043499999999142f),
   new PlayNote(Notes.F5, 72.00012f, 0.26086999999999705f),
   new PlayNote(Notes.G5, 72.26098999999999f, 0.26087000000001126f),
   new PlayNote(Notes.A5, 72.52186f, 0.26086999999999705f),
   new PlayNote(Notes.C6, 72.78273f, 0.26086999999999705f),
   new PlayNote(Notes.Cs6, 73.0436f, 0.26086999999999705f),
   new PlayNote(Notes.Gs5, 73.30447f, 0.26086999999999705f),
   new PlayNote(Notes.Gs5, 73.56533999999999f, 0.13043500000000563f),
   new PlayNote(Notes.G5, 73.695775f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 73.82621f, 0.13043499999999142f),
   new PlayNote(Notes.G5, 73.956645f, 1.173915000000008f),
   new PlayNote(Notes.F4, 75.13056f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 75.39143f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 75.6523f, 0.26086999999999705f),
   new PlayNote(Notes.F5, 75.91317f, 0.26086999999999705f),
   new PlayNote(Notes.E5, 76.17403999999999f, 0.5217400000000083f),
   new PlayNote(Notes.D5, 76.69578f, 0.5217399999999941f),
   new PlayNote(Notes.G4, 77.21752f, 0.5217400000000083f),
   new PlayNote(Notes.F5, 77.73926f, 0.5217399999999941f),
   new PlayNote(Notes.G5, 78.261f, 0.5217400000000083f),
   new PlayNote(Notes.E5, 78.78274f, 0.5217399999999941f),
   new PlayNote(Notes.D5, 79.30448f, 1.0434800000000024f),
   new PlayNote(Notes.A5, 80.34796f, 0.13043499999999142f),
   new PlayNote(Notes.Gs5, 80.47839499999999f, 0.13043500000000563f),
   new PlayNote(Notes.G5, 80.60883f, 0.13043500000000563f),
   new PlayNote(Notes.Fs5, 80.739265f, 0.13043499999999142f),
   new PlayNote(Notes.F5, 80.8697f, 0.13043500000000563f),
   new PlayNote(Notes.E5, 81.000135f, 0.13043499999999142f),
   new PlayNote(Notes.Ds5, 81.13056999999999f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 81.261005f, 0.13043500000000563f),
   new PlayNote(Notes.Gs4, 81.39144f, 0.9130449999999968f),
   new PlayNote(Notes.Ds5, 82.304485f, 1.1739149999999938f),
   new PlayNote(Notes.As3, 83.4784f, 1.5652199999999965f),
   new PlayNote(Notes.F4, 85.04361999999999f, 0.5217400000000083f),
   new PlayNote(Notes.E4, 85.56536f, 1.0434800000000024f),
   new PlayNote(Notes.D4, 86.60884f, 1.0434800000000024f),
   new PlayNote(Notes.F4, 87.65232f, 2.0869599999999906f),
   new PlayNote(Notes.As3, 91.82624f, 1.5652199999999965f),
   new PlayNote(Notes.F4, 93.39146f, 0.5217400000000083f),
   new PlayNote(Notes.E4, 93.9132f, 1.0434799999999882f),
   new PlayNote(Notes.D4, 94.95667999999999f, 1.0434800000000024f),
   new PlayNote(Notes.D4, 96.00016f, 2.086960000000005f),
   new PlayNote(Notes.D4, 100.17408f, 0.13043499999999142f),
   new PlayNote(Notes.D4, 100.304515f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 100.43495f, 0.26086999999999705f),
   new PlayNote(Notes.A4, 100.69582f, 0.3913050000000027f),
   new PlayNote(Notes.Gs4, 101.087125f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 101.347995f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 101.608865f, 0.26086999999999705f),
   new PlayNote(Notes.D4, 101.86973499999999f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 102.00017f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 102.130605f, 0.13043499999999142f),
   new PlayNote(Notes.C4, 102.26104f, 0.13043500000000563f),
   new PlayNote(Notes.C4, 102.391475f, 0.13043499999999142f),
   new PlayNote(Notes.D5, 102.52190999999999f, 0.26087000000001126f),
   new PlayNote(Notes.A4, 102.78278f, 0.39130499999998847f),
   new PlayNote(Notes.Gs4, 103.17408499999999f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 103.434955f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 103.695825f, 0.26086999999999705f),
   new PlayNote(Notes.D4, 103.956695f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 104.08713f, 0.13043499999999142f),
   new PlayNote(Notes.G4, 104.217565f, 0.13043500000000563f),
   new PlayNote(Notes.B3, 104.348f, 0.13043499999999142f),
   new PlayNote(Notes.B3, 104.47843499999999f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 104.60887f, 0.26086999999999705f),
   new PlayNote(Notes.A4, 104.86974f, 0.3913050000000027f),
   new PlayNote(Notes.Gs4, 105.261045f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 105.52191499999999f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 105.78278499999999f, 0.26087000000001126f),
   new PlayNote(Notes.D4, 106.043655f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 106.17408999999999f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 106.304525f, 0.13043499999999142f),
   new PlayNote(Notes.B3, 106.43495999999999f, 0.13043500000000563f),
   new PlayNote(Notes.B3, 106.565395f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 106.69583f, 0.26086999999999705f),
   new PlayNote(Notes.A4, 106.9567f, 0.3913050000000027f),
   new PlayNote(Notes.Gs4, 107.348005f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 107.608875f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 107.869745f, 0.26086999999999705f),
   new PlayNote(Notes.D4, 108.13061499999999f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 108.26105f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 108.391485f, 0.13043499999999142f),
   new PlayNote(Notes.D4, 108.52192f, 0.13043500000000563f),
   new PlayNote(Notes.D4, 108.652355f, 0.13043499999999142f),
   new PlayNote(Notes.D5, 108.78278999999999f, 0.26087000000001126f),
   new PlayNote(Notes.A4, 109.04366f, 0.39130499999998847f),
   new PlayNote(Notes.Gs4, 109.43496499999999f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 109.695835f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 109.956705f, 0.26086999999999705f),
   new PlayNote(Notes.D4, 110.217575f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 110.34801f, 0.13043499999999142f),
   new PlayNote(Notes.G4, 110.478445f, 0.13043500000000563f),
   new PlayNote(Notes.C4, 110.60888f, 0.13043499999999142f),
   new PlayNote(Notes.C4, 110.73931499999999f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 110.86975f, 0.26086999999999705f),
   new PlayNote(Notes.A4, 111.13062f, 0.3913050000000027f),
   new PlayNote(Notes.Gs4, 111.521925f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 111.782795f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 112.04366499999999f, 0.26087000000001126f),
   new PlayNote(Notes.D4, 112.304535f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 112.43496999999999f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 112.565405f, 0.13043499999999142f),
   new PlayNote(Notes.F5, 112.95671f, 0.26086999999999705f),
   new PlayNote(Notes.E5, 113.21758f, 0.13043499999999142f),
   new PlayNote(Notes.Gs4, 113.608885f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 113.869755f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 114.130625f, 0.26086999999999705f),
   new PlayNote(Notes.C4, 114.39149499999999f, 0.13043500000000563f),
   new PlayNote(Notes.E4, 114.52193f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 114.65236499999999f, 0.13043500000000563f),
   new PlayNote(Notes.F5, 115.04366999999999f, 0.26087000000001126f),
   new PlayNote(Notes.E5, 115.30454f, 0.13043499999999142f),
   new PlayNote(Notes.Gs4, 115.69584499999999f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 115.956715f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 116.217585f, 0.26086999999999705f),
   new PlayNote(Notes.C4, 116.478455f, 0.13043500000000563f),
   new PlayNote(Notes.E4, 116.60889f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 116.739325f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 116.86976f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 117.13063f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 117.3915f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 117.521935f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 117.782805f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 118.043675f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 118.30454499999999f, 0.26087000000001126f),
   new PlayNote(Notes.F4, 118.565415f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 118.69585f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 118.95671999999999f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 119.21759f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 119.47846f, 0.13043499999999142f),
   new PlayNote(Notes.G4, 119.60889499999999f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 119.869765f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 120.130635f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 120.391505f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 120.65237499999999f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 120.78281f, 0.26086999999999705f),
   new PlayNote(Notes.D5, 121.04368f, 0.26086999999999705f),
   new PlayNote(Notes.D5, 121.30454999999999f, 0.26086999999999705f),
   new PlayNote(Notes.D5, 121.56541999999999f, 0.13043500000000563f),
   new PlayNote(Notes.D5, 121.695855f, 0.26086999999999705f),
   new PlayNote(Notes.Gs4, 121.95672499999999f, 0.26086999999999705f),
   new PlayNote(Notes.Gs4, 122.21759499999999f, 0.26087000000001126f),
   new PlayNote(Notes.Gs4, 122.478465f, 0.26086999999999705f),
   new PlayNote(Notes.Gs4, 122.739335f, 0.13043500000000563f),
   new PlayNote(Notes.Gs4, 122.86977f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 123.13064f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 123.39151f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 123.65238f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 123.782815f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 124.043685f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 124.304555f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 124.56542499999999f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 124.826295f, 0.13043499999999142f),
   new PlayNote(Notes.G4, 124.95673f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 125.21759999999999f, 0.26087000000001126f),
   new PlayNote(Notes.F4, 125.47847f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 125.73934f, 0.13043499999999142f),
   new PlayNote(Notes.F4, 125.86977499999999f, 0.26087000000001126f),
   new PlayNote(Notes.F4, 126.130645f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 126.391515f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 126.652385f, 0.26086999999999705f),
   new PlayNote(Notes.F4, 126.91325499999999f, 0.13043500000000563f),
   new PlayNote(Notes.F4, 127.04369f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 127.30456f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 127.56542999999999f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 127.82629999999999f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 127.956735f, 0.26086999999999705f),
   new PlayNote(Notes.G4, 128.217605f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 128.478475f, 0.26086999999998284f),
   new PlayNote(Notes.G4, 128.739345f, 0.26087000000001126f),
   new PlayNote(Notes.G4, 129.000215f, 0.13043500000000563f),
   new PlayNote(Notes.G4, 129.13065f, 0.26086999999998284f),
   new PlayNote(Notes.D5, 129.39151999999999f, 0.26087000000001126f),
   new PlayNote(Notes.D5, 129.65239f, 0.26087000000001126f),
   new PlayNote(Notes.D5, 129.91326f, 0.1304349999999772f),
   new PlayNote(Notes.D5, 130.04369499999999f, 0.26087000000001126f),
};

    private float frequency1;

    public float sampleRate = 44100;
    public float waveLengthInSeconds = 2.0f;

    AudioSource audioSource;
    AudioReverbZone audioReverbZone;
    int timeIndex = 0;

    

    void OnAudioFilterRead(float[] data, int channels)
    {
        
        for (int i = 0; i < data.Length; i += channels)
        {
            data[i] =   CreateSine(timeIndex, 1.0f * frequency1, sampleRate, 0.2f * 1f) + 
                        CreateSine(timeIndex, 2.0f * frequency1, sampleRate, 0.2f * 0.5f) + 
                        CreateSine(timeIndex, 2.5f * frequency1, sampleRate, 0.2f * 0.33f) +
                        CreateSine(timeIndex, 3.0f * frequency1, sampleRate, 0.2f * 0.25f) +
                        CreateSine(timeIndex, 3.5f * frequency1, sampleRate, 0.2f * 0.2f) +
                        CreateSine(timeIndex, 4.0f * frequency1, sampleRate, 0.2f * 0.16f);

            if (channels == 2)
                data[i + 1] = data[i];

            timeIndex++;

            //if timeIndex gets too big, reset it to 0
            if (timeIndex >= (sampleRate * waveLengthInSeconds))
            {
                timeIndex = 0;
            }
        }
    }

    //Creates a sinewave
    float CreateSine(int timeIndex, float frequency, float sampleRate, float amplitude)
    {
        return Mathf.Sin(2 * Mathf.PI * timeIndex * frequency / sampleRate) * amplitude;
    }

    float remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    float fromHeightToFreq(float y)
    {
        var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        var y_min = endCollider.transform.position.y - colliderBounds.size.y / 2;
        var y_max = endCollider.transform.position.y + colliderBounds.size.y / 2;
        return remap(y, y_min, y_max, lowerBound, upperBound);
    }

    float fromFreqToHeigh(float freq)
    {
        var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        var y_min = endCollider.transform.position.y - colliderBounds.size.y / 2;
        var y_max = endCollider.transform.position.y + colliderBounds.size.y / 2;
        return remap(freq, lowerBound, upperBound, y_min, y_max);
    }

    float start_time;
    void Start()
    {
        factor = note.GetComponent<NoteLogic>().speed;

        maxTime = 1;
        //avoids audiosource from starting to play automatically
        audioSource = gameObject.AddComponent<AudioSource>();
        audioReverbZone = gameObject.AddComponent<AudioReverbZone>();
        audioSource.reverbZoneMix = 1f;
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0; //force 2D sound
        audioSource.Stop();

        GameObject newNote = Instantiate(note);
        notes.Add(newNote);
        //Bounds bounds = endCollider.GetComponent<Mesh>().bounds;
        newNote.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1f, 0, 1f, 0, 1f, 0, 1f);

        newNote.transform.localScale = new Vector3(newNote.transform.localScale.x, newNote.transform.localScale.y, song[count].duration * factor);
        var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;

        newNote.transform.position =
        new Vector3(endCollider.transform.position.x, fromFreqToHeigh(song[count].note), -3 - noteBounds.size.z);
        //initTime = 0;
        maxTime = song[count].duration;

        count += 1;
        start_time = Time.time;
    }

    private int count = 0; 

    // Update is called once per frame
    void Update()
    {

        if (midiPlayer.MPTK_IsPlaying)
        {
            initTime = (float)midiPlayer.MPTK_PlayTime.TotalSeconds + (start_time);
        }
        else
        {
            initTime += Time.deltaTime;

        }
        if (count < song.Count && initTime >= song[count].time)
        {
            float dif = initTime - song[count].time;
            GameObject newNote = Instantiate(note);
            notes.Add(newNote);
            //Bounds bounds = endCollider.GetComponent<Mesh>().bounds;
            newNote.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1f, 0, 1f, 0, 1f, 0, 1f);

            newNote.transform.localScale = new Vector3(newNote.transform.localScale.x, newNote.transform.localScale.y, song[count].duration * factor);
            var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;

            newNote.transform.position =
            new Vector3(endCollider.transform.position.x , fromFreqToHeigh(song[count].note), -3 - noteBounds.size.z + (dif * factor));
            //initTime = 0;

            count += 1;

        } 
        
        

        for (int i = notes.Count - 1; i >= 0; i--)
        {
            var note = notes[i];

            var noteBounds = note.GetComponent<MeshRenderer>().bounds;

            if (note.transform.position.z + noteBounds.size.z > endCollider.transform.position.z)
            {
                if (!midiPlayer.MPTK_IsPlaying)
                {
                    start_time = Time.time - start_time;
                    midiPlayer.MPTK_Play();
                    midiPlayer.MPTK_ChannelVolumeSet(0, 0.0f);

                }
                var y = note.transform.position.y;

                frequency1 = fromHeightToFreq(y);


                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
                note.transform.localScale -= new Vector3(0, 0, 0.02f);
                
                if (note.transform.localScale.z < 0)
                {
                    audioSource.Stop();
                    notes.RemoveAt(i);
                    Destroy(note);
                }

            }
        }

    }
}
