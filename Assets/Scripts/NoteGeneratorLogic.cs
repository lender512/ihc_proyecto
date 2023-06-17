using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteGeneratorLogic : MonoBehaviour
{
    public float maxTime = 1;
    private float initTime = 0;
    public GameObject note;
    public GameObject endCollider;
    public float height;
    private List<GameObject> notes = new List<GameObject>();

    [Range (0, 1000)]
    public float frequency1;
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
            data[i] = CreateSine(timeIndex, frequency1, sampleRate, 0.67f) + CreateSine(timeIndex, frequency2, sampleRate, 0.41f) + +CreateSine(timeIndex, frequency3, sampleRate, 0.15f);

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
        return ((value - from1) / (to1 - from1)) * (to2 - from2) + from1;
    }

    float fromHeightToFreq(float y)
    {
        var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        var y_min = endCollider.transform.position.y - colliderBounds.size.y / 2;
        var y_max = endCollider.transform.position.y + colliderBounds.size.y / 2;
        return remap(y, y_min, y_max, 440, 880);
    }

    float fromFreqToHeigh(float freq)
    {
        var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        var y_min = endCollider.transform.position.y - colliderBounds.size.y / 2;
        var y_max = endCollider.transform.position.y + colliderBounds.size.y / 2;
        return remap(freq, 440, 880, y_min, y_max);
    }


    void Start()
    {
        GameObject newNote = Instantiate(note);
        var bounds = newNote.GetComponent<MeshRenderer>().bounds;
        newNote.transform.position = endCollider.transform.position - new Vector3(bounds.size.x / 2, bounds.size.y / 2, -3);
        //Destroy(newNote, 5);
        //avoids audiosource from starting to play automatically
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0; //force 2D sound
        audioSource.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        if (initTime > maxTime)
        {
            GameObject newNote = Instantiate(note);
            notes.Add(newNote);
            //Bounds bounds = endCollider.GetComponent<Mesh>().bounds;
            var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;
            var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
            newNote.transform.position = endCollider.transform.position 
        + new Vector3(-noteBounds.size.x / 2, noteBounds.size.y / 2, -3)
                // +
            // new Vector3(0,
            //             fromFreqToHeigh(440), -3);

            +
            new Vector3(Random.Range(-colliderBounds.size.x / 2, colliderBounds.size.x / 2),
                       Random.Range(-colliderBounds.size.y / 2, colliderBounds.size.y / 2), -3);
            //Destroy(newNote, 5);
            initTime = 0;
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
