using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote {
    public float note;
    public float time;
    private readonly float beatLenght = 0.50f; // 120 bpm
    public PlayNote(float note, float time)
    {
        
        this.note = note;
        this.time = time * beatLenght;
    }
}

public static class Notes 
{

    public static float Silence = 0.0f;
    public static float LA3 = 220.000f;
    public static float LA3s = 466.164f;
    public static float SI3 = 246.942f;
    public static float DO4 = 261.626f;
    public static float RE4 = 293.665f;
    public static float MI4 = 329.628f;
    public static float FA4 = 349.228f;
    public static float FA4s = 369.994f;
    public static float SOL4 = 391.995f;
    public static float SOL4s = 415.305f;
    public static float LA4 = 440f;
    public static float SI4 = 493.88f;
    public static float DO5 = 523.25f;
    public static float RE5 = 587.33f;
    public static float MI5 = 659.25f;
    public static float FA5 = 698.46f;
    public static float SOL5 = 783.99f;
}

public class NoteGeneratorLogic : MonoBehaviour
{
    public float maxTime = 1;
    private float initTime = 0;
    public GameObject note;
    public GameObject endCollider;
    private List<GameObject> notes = new List<GameObject>();

    private readonly float lowerBound = 220.000f;
    private readonly float upperBound = 783.99f;
    private readonly float offset = 0.0f;

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

    private List<PlayNote> song = new List<PlayNote> {
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.DO4,     .25f),
        new PlayNote(Notes.DO4,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.SI3,     .25f),
        new PlayNote(Notes.SI3,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.LA3s,     .25f),
        new PlayNote(Notes.LA3s,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.DO4,     .25f),
        new PlayNote(Notes.DO4,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.SI3,     .25f),
        new PlayNote(Notes.SI3,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),

        new PlayNote(Notes.LA3s,     .25f),
        new PlayNote(Notes.LA3s,     .25f),
        new PlayNote(Notes.RE5,     .75f),
        new PlayNote(Notes.LA4,     .75f),
        new PlayNote(Notes.Silence, .25f),
        new PlayNote(Notes.SOL4s,   .75f),
        new PlayNote(Notes.SOL4,    .75f),
        new PlayNote(Notes.FA4,     .5f),
        new PlayNote(Notes.RE4,     .25f),
        new PlayNote(Notes.FA4,     .25f),
        new PlayNote(Notes.SOL4,    .25f),
    };
    private float frequency1;
    private float frequency2;
    private float frequency3;

    public float sampleRate = 44100;
    public float waveLengthInSeconds = 2.0f;

    AudioSource audioSource;
    int timeIndex = 0;

    

    void OnAudioFilterRead(float[] data, int channels)
    {
        
        for (int i = 0; i < data.Length; i += channels)
        {
            data[i] = CreateSine(timeIndex, frequency1, sampleRate, 0.67f) + CreateSine(timeIndex, frequency2, sampleRate, 0.3f) + +CreateSine(timeIndex, frequency3, sampleRate, 0.55f);

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


    void Start()
    {
        factor = note.GetComponent<NoteLogic>().speed;

        maxTime = 1;
        //avoids audiosource from starting to play automatically
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0; //force 2D sound
        audioSource.Stop();

    }

    private int count = 0; 

    // Update is called once per frame
    void Update()
    {
        if (initTime > maxTime && count < song.Count)
        {
            if (song[count].note != Notes.Silence)
            {
                GameObject newNote = Instantiate(note);
                notes.Add(newNote);
                //Bounds bounds = endCollider.GetComponent<Mesh>().bounds;
                var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;

                newNote.transform.localScale = new Vector3(newNote.transform.localScale.x, newNote.transform.localScale.y, (song[count].time) * factor );
                var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;

                newNote.transform.position =
                new Vector3(endCollider.transform.position.x 
                //+ Random.Range(-colliderBounds.size.x / 2, colliderBounds.size.x / 2)
                ,
                            fromFreqToHeigh(song[count].note), -3 - noteBounds.size.z);
                initTime = 0;
                maxTime = noteBounds.size.z / factor;

            } 
            else
            {
                initTime = 0;
                maxTime = song[count].time;
            }
            
            count += 1;

        }
        else
        {
            initTime += Time.deltaTime;
        }

        for (int i = notes.Count - 1; i >= 0; i--)
        {
            var note = notes[i];

            var noteBounds = note.GetComponent<MeshRenderer>().bounds;

            if (note.transform.position.z + noteBounds.size.z > endCollider.transform.position.z)
            {
                var y = note.transform.position.y;

                frequency1 = fromHeightToFreq(y);
                frequency2 = frequency1 * 2;
                frequency3 = frequency1 * 3;


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
