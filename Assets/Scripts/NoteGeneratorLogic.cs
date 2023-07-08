using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;




public class NoteGeneratorLogic : MonoBehaviour
{
    public float maxTime = 1;
    private float initTime = 0;
    public GameObject note;
    public GameObject endCollider;
    private List<GameObject> playingNotes = new List<GameObject>();
    public SongScript songScript;
    private float lowerBound = 65;
    private float upperBound = 1568f;
    private readonly float offset = 0.0f;
    public float normilizedLowebound;
    public float normilizedUpperbound;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject camera;
    public GameObject stars;
    public GameObject menuCanvas;
    private Vector3 menuCanvasPosition;
    public TextMeshPro score;

    private Song song;

    public MidiPlayerTK.MidiFilePlayer midiPlayer;

    public GameObject theremin;

    private float factor = 2;
    private List<float> allNotes = new List<float> {
        Notes.C2,
        Notes.Cs2,
        Notes.D2,
        Notes.Ds2,
        Notes.E2,
        Notes.F2,
        Notes.Fs2,
        Notes.G2,
        Notes.Gs2,
        Notes.A2,
        Notes.As2,
        Notes.B2,
        Notes.C3,
        Notes.Cs3,
        Notes.D3,
        Notes.E3,
        Notes.F3,
        Notes.Fs3,
        Notes.G3,
        Notes.Gs3,
        Notes.A3,
        Notes.As3,
        Notes.B3,
        Notes.C4,
        Notes.Cs4,
        Notes.D4,
        Notes.E4,
        Notes.F4,
        Notes.Fs4,
        Notes.G4,
        Notes.Gs4,
        Notes.A4,
        Notes.As4,
        Notes.B4,
        Notes.C5,
        Notes.Cs5,
        Notes.D5,
        Notes.Ds5,
        Notes.E5,
        Notes.F5,
        Notes.Fs5,
        Notes.G5,
        Notes.Gs5,
        Notes.A5,
        Notes.As5,
        Notes.B5,
        Notes.C6,
        Notes.Cs6,
        Notes.D6,
        Notes.Ds6,
        Notes.E6,
        Notes.F6,
        Notes.Fs6,
        Notes.G6
    };

    public float frequency1;
    private float noteThreshold = 2f;
    public float sampleRate = 44100;
    public float waveLengthInSeconds = 2.0f;
    public int channel = 3;
    public Slider slider;
    float phase = 0;
    float phase2 = 0;

    


    AudioSource audioSource;
    AudioReverbZone audioReverbZone;
    int timeIndex = 0;

    float GetClosestFreq(float frequency) {
        float minDist = 100000;
        float minFreq = 0;
        for (int note = 0; note < allNotes.Count; note++) {
            // float newDist = Mathf.Abs(Mathf.Log(2, allNotes[note]) - Mathf.Log(2, frequency));
            float newDist = Mathf.Abs(allNotes[note] - frequency);
            if (newDist < minDist) {
                minDist = newDist;
                minFreq = allNotes[note];
            }
        }
        return minFreq;
    }

    void OnAudioFilterRead(float[] data, int channels)
    {
        for(int i = 0 ; i < data.Length ; i += channels)
        {  
            phase += 2 * Mathf.PI * frequency1 / sampleRate;
            phase2 += 2 * Mathf.PI * frequency1 * 2 / sampleRate;
 
            data[i] = Mathf.Sin(phase);
            if (channels > 1) data[i+1] = 0.3f * Mathf.Sin(phase2);;
 
            if (phase >= 2 * Mathf.PI)
            {
                phase -= 2 * Mathf.PI;
            }
            if (phase2 >= 2 * Mathf.PI)
            {
                phase2 -= 2 * Mathf.PI;
            }
        }
        // for (int i = 0; i < data.Length; i += channels)
        // {
        //     data[i] =   CreateSine(timeIndex, 1.0f * curFreq, sampleRate, 0.5f * 1f) ;
        //     // + 
        //     //             CreateSine(timeIndex, 2.0f * frequency1, sampleRate, 0.2f * 0.8f) + 
        //     //             CreateSine(timeIndex, 3.0f * frequency1, sampleRate, 0.2f * 0.6f) +
        //     //             CreateSine(timeIndex, 4.0f * frequency1, sampleRate, 0.2f * 0.3f) +
        //     //             CreateSine(timeIndex, 5.0f * frequency1, sampleRate, 0.2f * 0.2f) +
        //     //             CreateSine(timeIndex, 6.0f * frequency1, sampleRate, 0.2f * 0.16f);

        //     if (channels == 2)
        //         data[i + 1] = data[i];

        //     timeIndex++;

        //     //if timeIndex gets too big, reset it to 0
        //     if (timeIndex >= (sampleRate))
        //     {
        //         timeIndex = 0;
        //     }
        // }
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
        return Mathf.Pow(2, remap(y, y_min, y_max, normilizedLowebound, normilizedUpperbound));
    }

    // float fromHeightToFreq(float y)
    // {
    //     var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
    //     var y_min = endCollider.transform.position.y - colliderBounds.size.y / 2;
    //     var y_max = endCollider.transform.position.y + colliderBounds.size.y / 2;
    //     return remap(y, y_min, y_max,lowerBound, upperBound);
    // }

    float fromFreqToHeigh(float freq)
    {
        freq = Mathf.Log(freq, 2);
        var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        var y_min = endCollider.transform.position.y - colliderBounds.size.y / 2;
        var y_max = endCollider.transform.position.y + colliderBounds.size.y / 2;
        return remap(freq, normilizedLowebound, normilizedUpperbound, y_min, y_max);
    }

    float start_time;
    float noteEdge;
    int lowerIndex = 0;
    int upperIndex = 0;
    float oldSpeed = 0.0f;
    float currentNoteHeight = 0.0f;
    float scoreFloat = 0.0f;
    private int scoreFactor = 5;
    float possibleScore;
    float starsXPosition;
    Bounds colliderBounds;

    float CalculatePossibleScore() {
        float possibleScoreTime = 0;

        for (int i = 0; i < song.notes.Count; i++) {
            possibleScoreTime += song.notes[i].duration;
        }

        possibleScoreTime *= 5;

        return possibleScoreTime * 0.95f;

    }

    void Start()
    {
        songScript = MenuPlayController.selectedSongScript;
        song = songScript.GetComponent<SongScript>().GetSong();
        theremin.GetComponent<Renderer>().material.color = MenuColorController.selectedColor;

        possibleScore = CalculatePossibleScore();
        starsXPosition = stars.transform.position.x;
        menuCanvasPosition = new Vector3 (menuCanvas.transform.position.x, menuCanvas.transform.position.y, menuCanvas.transform.position.z);
        menuCanvas.transform.position = new Vector3(0, -100, 0);
        colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        slider.value = 0.0f;

        score.text = "HOla";


        midiPlayer.MPTK_MidiIndex = song.index;

        //TODO: fix
        song.notes.Insert(0, new PlayNote(Notes.C4, 0.0f, 0.0f));

        float lowerFreq = 100000;
        float highFreq = 0;

        
        for (int i = 0; i < song.notes.Count; i++) {
            lowerFreq = Mathf.Min(lowerFreq, song.notes[i].note);
            if (lowerFreq > song.notes[i].note) {
                lowerFreq = song.notes[i].note;
            }
            if (highFreq < song.notes[i].note) {
                highFreq = song.notes[i].note;

            }
            // highFreq = Mathf.Max(highFreq, song.notes[i].note);
        }

        for (int i = 0; i < allNotes.Count; i++) {
            if (allNotes[i] == highFreq)    upperIndex = i;
            if (allNotes[i] == lowerFreq)   lowerIndex = i;
        }
        
        lowerBound = lowerFreq;
        upperBound = highFreq;

        noteEdge = colliderBounds.size.y / (lowerIndex - upperIndex);

        factor = note.GetComponent<NoteLogic>().speed;
        normilizedLowebound = Mathf.Log(lowerBound, 2);
        normilizedUpperbound = Mathf.Log(upperBound, 2);

        maxTime = 1;
        //avoids audiosource from starting to play automatically
        audioSource = gameObject.AddComponent<AudioSource>();
        audioReverbZone = gameObject.AddComponent<AudioReverbZone>();
        audioSource.reverbZoneMix = 1f;
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0; //force 2D sound
        audioSource.Stop();
        channel = song.channel;
        GameObject newNote = Instantiate(note);
        playingNotes.Add(newNote);
        //Bounds bounds = endCollider.GetComponent<Mesh>().bounds;
        newNote.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1f, 0, 1f, 0, 1f, 0, 1f);

        newNote.transform.localScale = new Vector3(newNote.transform.localScale.x, newNote.transform.localScale.y, song.notes[count].duration * factor);
        var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;

        newNote.transform.position =
        new Vector3(endCollider.transform.position.x, fromFreqToHeigh(song.notes[count].note), -3 - noteBounds.size.z);
        //initTime = 0;
        maxTime = song.notes[count].duration;

        count += 1;
        start_time = Time.time;
        oldSpeed = factor;

    }

    private int count = 0; 
    bool isPaused = false;
    // Update is called once per frame
    void Update()
    {
        RectTransform rt = stars.GetComponent (typeof (RectTransform)) as RectTransform;
        stars.transform.position = new Vector3(starsXPosition - scoreFloat/possibleScore, stars.transform.position.y, stars.transform.position.z);
        rt.sizeDelta = new Vector2 (scoreFloat/possibleScore, rt.sizeDelta.y);
        if (OVRInput.GetUp(OVRInput.Button.Start)) {
            isPaused = !isPaused;
            // yield return new WaitForSeconds(1);
            if (!isPaused) {                
                factor = oldSpeed;
                menuCanvas.transform.position = new Vector3(0, -100, 0);
                midiPlayer.MPTK_Play();
                for (int i = playingNotes.Count - 1; i >= 0; i--)
                {
                    playingNotes[i].GetComponent<NoteLogic>().speed = oldSpeed;
                }
            }
        } 
        if (isPaused) {
            midiPlayer.MPTK_Pause();
            menuCanvas.transform.position = new Vector3 (menuCanvasPosition.x, menuCanvasPosition.y, menuCanvasPosition.z);
            factor = 0;
            for (int i = playingNotes.Count - 1; i >= 0; i--)
            {
                playingNotes[i].GetComponent<NoteLogic>().speed = 0;
            }
        } else {
            var y = rightHand.transform.position.y;

        score.text = ((int) scoreFloat).ToString(); 
        if (midiPlayer.MPTK_IsPlaying)
        {
            for (int i = 0; i < midiPlayer.Channels.Length; i++)
                midiPlayer.MPTK_ChannelVolumeSet(i, 0.8f);
            midiPlayer.MPTK_ChannelVolumeSet(channel, 0.0f);
        }

        
        
        if (midiPlayer.MPTK_IsPlaying)
        {
            slider.value = (float) (midiPlayer.MPTK_PlayTime.TotalSeconds / midiPlayer.MPTK_Duration.TotalSeconds);
            initTime = (float)midiPlayer.MPTK_PlayTime.TotalSeconds + (start_time);
        }
        else
        {
            initTime += Time.deltaTime;

        }
        if (count < song.notes.Count && initTime >= song.notes[count].time)
        {
            float dif = initTime - song.notes[count].time;
            GameObject newNote = Instantiate(note);
            playingNotes.Add(newNote);
            newNote.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1f, 0, 1f, 0, 1f, 0, 1f);

            newNote.transform.localScale = new Vector3(noteEdge, noteEdge, song.notes[count].duration * factor);
            var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;

            newNote.transform.position =
            new Vector3(endCollider.transform.position.x , fromFreqToHeigh(song.notes[count].note), -3 - noteBounds.size.z + (dif * factor));
            //initTime = 0;

            count += 1;

        }
        // ANTIDEBUG
        if ((y > endCollider.transform.position.y - 0.1f- colliderBounds.size.y / 2) && (y < endCollider.transform.position.y + 0.1f + colliderBounds.size.y / 2)) {
            if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.01f && 
            Mathf.Abs(rightHand.transform.position.z - endCollider.transform.position.z) < 0.15f) {

            if (Mathf.Abs(y-currentNoteHeight) < 0.05f) {
                    y = currentNoteHeight;
                    scoreFloat += Time.deltaTime * scoreFactor;

            }

            float newFreq = fromHeightToFreq(y);

            // frequency1 = GetClosestFreq(newFreq);
            frequency1 = ((int) (newFreq / 10)) * 10.0f;
            // frequency1 = newFreq;
            if (!audioSource.isPlaying) audioSource.Play();
            } 
            else 
            {
            audioSource.Stop();
            }
        } else {
            audioSource.Stop();
        }

        

        //

        

        for (int i = playingNotes.Count - 1; i >= 0; i--)
        {
            var note = playingNotes[i];

            var noteBounds = note.GetComponent<MeshRenderer>().bounds;

            if (note.transform.position.z + noteBounds.size.z > endCollider.transform.position.z)
            {
                if (currentNoteHeight == y) {
                    note.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
                } else {
                    note.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                }
                currentNoteHeight = note.transform.position.y; 
                if (!midiPlayer.MPTK_IsPlaying)
                {
                    start_time = Time.time - start_time;
                    midiPlayer.MPTK_Play();

                    //midiPlayer.MPTK_ChannelVolumeSet(song.channel, 0.0f);

                }

                //DEBUG
                // var y = note.transform.position.y;
                // float newFreq = fromHeightToFreq(y);

                // frequency1 = ((int)(newFreq / 10)) * 10.0f;
                //

                if (!audioSource.isPlaying)
                {
                    //DEBUG
                    // audioSource.Play();
                    //
                }
                note.transform.localScale -= new Vector3(0, 0, factor * Time.deltaTime);
               
                
                if (note.transform.localScale.z < 0)
                {
                    //DEBUG
                    // audioSource.Stop();
                    //
                    currentNoteHeight = -10.0f;
                    playingNotes.RemoveAt(i);
                    Destroy(note);
                }

            }
        }
        }
        // Bounds colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
        
        
    }
    public void ReturnMenu() {  
        SceneManager.LoadScene(0);  
    }
    public void ResetrScene() {  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}
