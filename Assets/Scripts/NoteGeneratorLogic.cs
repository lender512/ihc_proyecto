using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NoteGeneratorLogic : MonoBehaviour
{
    public float maxTime = 1;
    private float initTime = 0;
    public GameObject note;
    public GameObject endCollider;
    private List<GameObject> playingNotes = new List<GameObject>();
    public SongScript songScript;
    public float lowerBound = 65;
    public float upperBound = 1568f;
    private readonly float offset = 0.0f;
    public float normilizedLowebound;
    public float normilizedUpperbound;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject camera;

    private Song song;

    public MidiPlayerTK.MidiFilePlayer midiPlayer;

    private float factor = 2;
/*
private List<PlayNote> song = new List<PlayNote> {   new PlayNote(Notes.Fs4, 16.105263157894736f, 0.06315789473684319f),
   new PlayNote(Notes.Cs4, 16.231578947368423f, 0.12631578947368283f),
   new PlayNote(Notes.Fs4, 16.48421052631579f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 16.736842105263158f, 0.2526315789473692f),
   new PlayNote(Notes.Gs4, 17.11578947368421f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 17.242105263157896f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 17.36842105263158f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 17.49473684210526f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 17.621052631578948f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 17.74736842105263f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 18.0f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 18.126315789473683f, 0.06315789473684319f),
   new PlayNote(Notes.Gs4, 18.25263157894737f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 18.50526315789474f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 18.757894736842104f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 19.010526315789473f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 19.263157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 19.51578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 19.768421052631577f, 0.18947368421052957f),
   new PlayNote(Notes.Fs4, 20.021052631578947f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 20.147368421052633f, 0.06315789473683964f),
   new PlayNote(Notes.Cs4, 20.273684210526316f, 0.12631578947368283f),
   new PlayNote(Notes.Fs4, 20.526315789473685f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 20.778947368421054f, 0.25263157894736565f),
   new PlayNote(Notes.Gs4, 21.157894736842106f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 21.28421052631579f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 21.53684210526316f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 21.66315789473684f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 21.91578947368421f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 22.042105263157893f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 22.16842105263158f, 0.06315789473684319f),
   new PlayNote(Notes.Cs5, 22.294736842105262f, 0.06315789473684319f),
   new PlayNote(Notes.Cs5, 22.42105263157895f, 0.06315789473683964f),
   new PlayNote(Notes.Cs5, 22.54736842105263f, 0.06315789473684319f),
   new PlayNote(Notes.B4, 22.673684210526314f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 22.8f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 22.926315789473684f, 0.06315789473684319f),
   new PlayNote(Notes.Gs4, 23.05263157894737f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 23.305263157894736f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 23.557894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 23.810526315789474f, 0.12631578947368283f),
   new PlayNote(Notes.Fs4, 24.063157894736843f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 24.189473684210526f, 0.06315789473684319f),
   new PlayNote(Notes.Cs5, 24.31578947368421f, 0.18947368421052957f),
   new PlayNote(Notes.Cs5, 24.568421052631578f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 24.821052631578947f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 25.073684210526316f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 25.326315789473686f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 25.57894736842105f, 0.06315789473684319f),
   new PlayNote(Notes.E4, 25.705263157894738f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 25.957894736842107f, 0.06315789473683964f),
   new PlayNote(Notes.E4, 26.08421052631579f, 0.06315789473684319f),
   new PlayNote(Notes.Gs4, 26.210526315789473f, 0.06315789473684319f),
   new PlayNote(Notes.B4, 26.33684210526316f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 26.46315789473684f, 0.06315789473684319f),
   new PlayNote(Notes.B4, 26.589473684210525f, 0.06315789473684319f),
   new PlayNote(Notes.B4, 26.71578947368421f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 26.842105263157894f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 26.96842105263158f, 0.06315789473683964f),
   new PlayNote(Notes.Gs4, 27.094736842105263f, 0.06315789473684319f),
   new PlayNote(Notes.Gs4, 27.221052631578946f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 27.347368421052632f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 27.6f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 27.726315789473684f, 0.2526315789473692f),
   new PlayNote(Notes.Fs4, 28.231578947368423f, 0.06315789473683964f),
   new PlayNote(Notes.Cs5, 28.357894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 28.610526315789475f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 28.86315789473684f, 0.18947368421052957f),
   new PlayNote(Notes.A4, 29.11578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 29.36842105263158f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 29.621052631578948f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 29.873684210526317f, 0.12631578947368283f),
   new PlayNote(Notes.E4, 30.126315789473683f, 0.06315789473684319f),
   new PlayNote(Notes.Gs4, 30.25263157894737f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 30.378947368421052f, 0.06315789473684319f),
   new PlayNote(Notes.B4, 30.50526315789474f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 30.63157894736842f, 0.06315789473684319f),
   new PlayNote(Notes.B4, 30.757894736842104f, 0.06315789473684319f),
   new PlayNote(Notes.A4, 30.88421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 31.13684210526316f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 31.389473684210525f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 31.642105263157895f, 0.06315789473684319f),
   new PlayNote(Notes.Fs4, 31.768421052631577f, 0.31578947368420884f),
   new PlayNote(Notes.Fs4, 32.27368421052632f, 0.06315789473683964f),
   new PlayNote(Notes.Cs4, 32.4f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 32.65263157894737f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 32.90526315789474f, 0.25263157894736565f),
   new PlayNote(Notes.Gs4, 33.28421052631579f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 33.410526315789475f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 33.536842105263155f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 33.66315789473684f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 33.78947368421053f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 33.915789473684214f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 34.16842105263158f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 34.294736842105266f, 0.06315789473683964f),
   new PlayNote(Notes.Gs4, 34.421052631578945f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 34.67368421052632f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 34.92631578947368f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 35.17894736842105f, 0.18947368421053312f),
   new PlayNote(Notes.Gs4, 35.43157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 35.68421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 35.93684210526316f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 36.189473684210526f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 36.31578947368421f, 0.06315789473683964f),
   new PlayNote(Notes.Cs4, 36.44210526315789f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 36.694736842105264f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 36.94736842105263f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 37.32631578947368f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 37.45263157894737f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 37.705263157894734f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 37.83157894736842f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 38.084210526315786f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 38.21052631578947f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 38.33684210526316f, 0.06315789473683964f),
   new PlayNote(Notes.Cs5, 38.463157894736845f, 0.06315789473683964f),
   new PlayNote(Notes.Cs5, 38.589473684210525f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 38.71578947368421f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 38.8421052631579f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 38.96842105263158f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 39.09473684210526f, 0.06315789473683964f),
   new PlayNote(Notes.Gs4, 39.22105263157895f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 39.473684210526315f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 39.72631578947368f, 0.18947368421053312f),
   new PlayNote(Notes.Fs4, 39.97894736842105f, 0.12631578947368638f),
   new PlayNote(Notes.Fs4, 40.23157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 40.357894736842105f, 0.06315789473683964f),
   new PlayNote(Notes.Cs5, 40.48421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 40.73684210526316f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 40.98947368421052f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 41.242105263157896f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 41.49473684210526f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 41.747368421052634f, 0.06315789473683964f),
   new PlayNote(Notes.E4, 41.873684210526314f, 0.12631578947368638f),
   new PlayNote(Notes.E4, 42.126315789473686f, 0.06315789473683964f),
   new PlayNote(Notes.E4, 42.252631578947366f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 42.37894736842105f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 42.50526315789474f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 42.63157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 42.757894736842104f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 42.88421052631579f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 43.01052631578948f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 43.136842105263156f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 43.26315789473684f, 0.06315789473683964f),
   new PlayNote(Notes.Gs4, 43.38947368421053f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 43.51578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 43.76842105263158f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 43.89473684210526f, 0.25263157894737276f),
   new PlayNote(Notes.Fs4, 44.4f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 44.526315789473685f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 44.77894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 45.03157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 45.28421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 45.536842105263155f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 45.78947368421053f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 46.04210526315789f, 0.12631578947368638f),
   new PlayNote(Notes.E4, 46.294736842105266f, 0.06315789473683964f),
   new PlayNote(Notes.Gs4, 46.421052631578945f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 46.54736842105263f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 46.67368421052632f, 0.06315789473683964f),
   new PlayNote(Notes.B4, 46.8f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 46.92631578947368f, 0.06315789473683964f),
   new PlayNote(Notes.A4, 47.05263157894737f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 47.305263157894736f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 47.55789473684211f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 47.810526315789474f, 0.06315789473683964f),
   new PlayNote(Notes.Fs4, 47.93684210526316f, 0.3157894736842053f),
   new PlayNote(Notes.Fs4, 80.77894736842106f, 0.06315789473683253f),
   new PlayNote(Notes.Cs4, 80.90526315789474f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 81.15789473684211f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 81.41052631578947f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 81.78947368421052f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 81.91578947368421f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 82.0421052631579f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 82.16842105263157f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 82.29473684210527f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 82.42105263157895f, 0.12631578947369348f),
   new PlayNote(Notes.Fs4, 82.67368421052632f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 82.8f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 82.92631578947369f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 83.17894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 83.43157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 83.6842105263158f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 83.93684210526315f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 84.18947368421053f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 84.4421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 84.69473684210526f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 84.82105263157895f, 0.06315789473683253f),
   new PlayNote(Notes.Cs4, 84.94736842105263f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 85.2f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 85.45263157894736f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 85.83157894736843f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 85.9578947368421f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 86.21052631578948f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 86.33684210526316f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 86.58947368421053f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 86.71578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 86.84210526315789f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 86.96842105263158f, 0.06315789473683253f),
   new PlayNote(Notes.Cs5, 87.09473684210526f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 87.22105263157894f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 87.34736842105264f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 87.47368421052632f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 87.6f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 87.72631578947369f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 87.97894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 88.23157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 88.48421052631579f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 88.73684210526316f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 88.86315789473684f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 88.98947368421052f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 89.2421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 89.49473684210527f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 89.74736842105263f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 90.0f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 90.25263157894737f, 0.06315789473683253f),
   new PlayNote(Notes.E4, 90.37894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 90.63157894736842f, 0.06315789473683253f),
   new PlayNote(Notes.E4, 90.7578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 90.88421052631578f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 91.01052631578948f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 91.26315789473684f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 91.51578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 91.76842105263158f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 92.02105263157895f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 92.27368421052631f, 0.06315789473684674f),
   new PlayNote(Notes.E4, 92.4f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 92.65263157894736f, 0.06315789473684674f),
   new PlayNote(Notes.E4, 92.77894736842106f, 0.06315789473683253f),
   new PlayNote(Notes.Gs4, 92.90526315789474f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 93.03157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 93.28421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 93.53684210526316f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 93.78947368421052f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 94.0421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 94.29473684210527f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 94.54736842105264f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 94.8f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 95.05263157894737f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 95.30526315789474f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 95.5578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 95.81052631578947f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 96.06315789473685f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 96.3157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 96.56842105263158f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 96.69473684210526f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 96.82105263157895f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 96.94736842105263f, 0.06315789473684674f),
   new PlayNote(Notes.Cs4, 97.07368421052631f, 0.12631578947369348f),
   new PlayNote(Notes.Fs4, 97.32631578947368f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 97.57894736842105f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 97.9578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 98.08421052631579f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 98.21052631578948f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 98.33684210526316f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 98.46315789473684f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 98.58947368421053f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 98.84210526315789f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 98.96842105263158f, 0.06315789473683253f),
   new PlayNote(Notes.Gs4, 99.09473684210526f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 99.34736842105264f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 99.6f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 99.85263157894737f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 100.10526315789474f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 100.3578947368421f, 0.18947368421054023f),
   new PlayNote(Notes.Fs4, 100.61052631578947f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 100.86315789473684f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 100.98947368421052f, 0.06315789473684674f),
   new PlayNote(Notes.Cs4, 101.11578947368422f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 101.36842105263158f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 101.62105263157895f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 102.0f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 102.12631578947368f, 0.12631578947369348f),
   new PlayNote(Notes.Fs4, 102.37894736842105f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 102.50526315789473f, 0.12631578947369348f),
   new PlayNote(Notes.Fs4, 102.7578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 102.88421052631578f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 103.01052631578948f, 0.06315789473683253f),
   new PlayNote(Notes.Cs5, 103.13684210526316f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 103.26315789473684f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 103.38947368421053f, 0.06315789473683253f),
   new PlayNote(Notes.B4, 103.51578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 103.6421052631579f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 103.76842105263158f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 103.89473684210526f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 104.14736842105263f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 104.4f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 104.65263157894736f, 0.12631578947369348f),
   new PlayNote(Notes.Fs4, 104.90526315789474f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 105.03157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 105.15789473684211f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 105.41052631578947f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 105.66315789473684f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 105.91578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 106.16842105263157f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 106.42105263157895f, 0.06315789473684674f),
   new PlayNote(Notes.E4, 106.54736842105264f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 106.8f, 0.06315789473684674f),
   new PlayNote(Notes.E4, 106.92631578947369f, 0.06315789473683253f),
   new PlayNote(Notes.Gs4, 107.05263157894737f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 107.17894736842105f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 107.30526315789474f, 0.06315789473683253f),
   new PlayNote(Notes.B4, 107.43157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 107.5578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 107.6842105263158f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 107.81052631578947f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 107.93684210526315f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 108.06315789473685f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 108.18947368421053f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 108.4421052631579f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 108.56842105263158f, 0.25263157894737276f),
   new PlayNote(Notes.Fs4, 109.07368421052631f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 109.2f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 109.45263157894736f, 0.18947368421054023f),
   new PlayNote(Notes.B4, 109.70526315789473f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 109.9578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 110.21052631578948f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 110.46315789473684f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 110.71578947368421f, 0.12631578947367927f),
   new PlayNote(Notes.E4, 110.96842105263158f, 0.06315789473683253f),
   new PlayNote(Notes.Gs4, 111.09473684210526f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 111.22105263157894f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 111.34736842105264f, 0.06315789473683253f),
   new PlayNote(Notes.B4, 111.47368421052632f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 111.6f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 111.72631578947369f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 111.97894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 112.23157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 112.48421052631579f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 112.61052631578947f, 0.3157894736842195f),
   new PlayNote(Notes.Fs4, 113.11578947368422f, 0.06315789473683253f),
   new PlayNote(Notes.Cs4, 113.2421052631579f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 113.49473684210527f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 113.74736842105263f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 114.12631578947368f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 114.25263157894737f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 114.37894736842105f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 114.50526315789473f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 114.63157894736842f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 114.7578947368421f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 115.01052631578948f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 115.13684210526316f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 115.26315789473684f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 115.51578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 115.76842105263158f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 116.02105263157895f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 116.27368421052631f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 116.52631578947368f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 116.77894736842106f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 117.03157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 117.15789473684211f, 0.06315789473683253f),
   new PlayNote(Notes.Cs4, 117.28421052631579f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 117.53684210526316f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 117.78947368421052f, 0.25263157894737276f),
   new PlayNote(Notes.Gs4, 118.16842105263157f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 118.29473684210527f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 118.54736842105264f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 118.67368421052632f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 118.92631578947369f, 0.06315789473683253f),
   new PlayNote(Notes.Fs4, 119.05263157894737f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 119.17894736842105f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 119.30526315789474f, 0.06315789473683253f),
   new PlayNote(Notes.Cs5, 119.43157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 119.5578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 119.6842105263158f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 119.81052631578947f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 119.93684210526315f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 120.06315789473685f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 120.3157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 120.56842105263158f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 120.82105263157895f, 0.12631578947367927f),
   new PlayNote(Notes.Fs4, 121.07368421052631f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 121.2f, 0.06315789473683253f),
   new PlayNote(Notes.Cs5, 121.32631578947368f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 121.57894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 121.83157894736843f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 122.08421052631579f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 122.33684210526316f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 122.58947368421053f, 0.06315789473683253f),
   new PlayNote(Notes.E4, 122.71578947368421f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 122.96842105263158f, 0.06315789473683253f),
   new PlayNote(Notes.E4, 123.09473684210526f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 123.22105263157894f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 123.34736842105264f, 0.06315789473683253f),
   new PlayNote(Notes.B4, 123.47368421052632f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 123.6f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 123.72631578947369f, 0.06315789473683253f),
   new PlayNote(Notes.A4, 123.85263157894737f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 123.97894736842105f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 124.10526315789474f, 0.06315789473683253f),
   new PlayNote(Notes.Gs4, 124.23157894736842f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 124.3578947368421f, 0.18947368421054023f),
   new PlayNote(Notes.Fs4, 124.61052631578947f, 0.06315789473684674f),
   new PlayNote(Notes.Fs4, 124.73684210526316f, 0.25263157894735855f),
   new PlayNote(Notes.Fs4, 125.2421052631579f, 0.06315789473684674f),
   new PlayNote(Notes.Cs5, 125.36842105263158f, 0.18947368421052602f),
   new PlayNote(Notes.Cs5, 125.62105263157895f, 0.18947368421052602f),
   new PlayNote(Notes.B4, 125.87368421052632f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 126.12631578947368f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 126.37894736842105f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 126.63157894736842f, 0.18947368421052602f),
   new PlayNote(Notes.E4, 126.88421052631578f, 0.12631578947369348f),
   new PlayNote(Notes.E4, 127.13684210526316f, 0.06315789473684674f),
   new PlayNote(Notes.Gs4, 127.26315789473684f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 127.38947368421053f, 0.06315789473683253f),
   new PlayNote(Notes.B4, 127.51578947368421f, 0.06315789473684674f),
   new PlayNote(Notes.B4, 127.6421052631579f, 0.06315789473683253f),
   new PlayNote(Notes.B4, 127.76842105263158f, 0.06315789473684674f),
   new PlayNote(Notes.A4, 127.89473684210526f, 0.18947368421052602f),
   new PlayNote(Notes.Gs4, 128.14736842105262f, 0.18947368421052602f),
   new PlayNote(Notes.A4, 128.4f, 0.18947368421052602f),
   new PlayNote(Notes.Fs4, 128.65263157894736f, 0.06315789473683253f),
};
*/
    /*

    private List<PlayNote> song = 
    //*/

//volaré
/*

*/
    private List<float> allNotes = new List<float> {
        Notes.C2,
        Notes.Cs2,
        Notes.D2,
        Notes.E2,
        Notes.F2,
        Notes.F2s,
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
        Notes.F3s,
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

    public float sampleRate = 44100;
    public float waveLengthInSeconds = 2.0f;

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
        
        for (int i = 0; i < data.Length; i += channels)
        {
            data[i] =   CreateSine(timeIndex, 1.0f * frequency1, sampleRate, 0.5f * 1f) ;
            // + 
            //             CreateSine(timeIndex, 2.0f * frequency1, sampleRate, 0.2f * 0.8f) + 
            //             CreateSine(timeIndex, 3.0f * frequency1, sampleRate, 0.2f * 0.6f) +
            //             CreateSine(timeIndex, 4.0f * frequency1, sampleRate, 0.2f * 0.3f) +
            //             CreateSine(timeIndex, 5.0f * frequency1, sampleRate, 0.2f * 0.2f) +
            //             CreateSine(timeIndex, 6.0f * frequency1, sampleRate, 0.2f * 0.16f);

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
    void Start()
    {
        song = songScript.GetComponent<SongScript>().GetSong();
        midiPlayer.MPTK_MidiIndex = song.index;
        float lowerFreq = 100000;
        float highFreq = 0;
        for (int i = 0; i < song.notes.Count; i++) {
            lowerFreq = Mathf.Min(lowerFreq, song.notes[i].note);
            highFreq = Mathf.Max(highFreq, song.notes[i].note);
        }
        
        lowerBound = lowerFreq;
        upperBound = highFreq;

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
    }

    private int count = 0; 

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick)) {
        }
        
        if (midiPlayer.MPTK_IsPlaying)
        {
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
            //Bounds bounds = endCollider.GetComponent<Mesh>().bounds;
            newNote.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1f, 0, 1f, 0, 1f, 0, 1f);

            newNote.transform.localScale = new Vector3(newNote.transform.localScale.x, newNote.transform.localScale.y, song.notes[count].duration * factor);
            var noteBounds = newNote.GetComponent<MeshRenderer>().bounds;

            newNote.transform.position =
            new Vector3(endCollider.transform.position.x , fromFreqToHeigh(song.notes[count].note), -3 - noteBounds.size.z + (dif * factor));
            //initTime = 0;

            count += 1;

        }
        // ANTIDEBUG

        //if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.01f && Mathf.Abs(rightHand.transform.position.z - endCollider.transform.position.z) < 0.15f ) {
        //    var y = rightHand.transform.position.y;
        //    float newFreq = fromHeightToFreq(y);

        //    // frequency1 = GetClosestFreq(newFreq);
        //    frequency1 = ((int) (newFreq / 20)) * 20.0f;
        //    // frequency1 = newFreq;
        //    if (!audioSource.isPlaying) audioSource.Play();
        //} 
        //else 
        //{
        //    audioSource.Stop();
        //}

        //

        

        for (int i = playingNotes.Count - 1; i >= 0; i--)
        {
            var note = playingNotes[i];

            var noteBounds = note.GetComponent<MeshRenderer>().bounds;

            if (note.transform.position.z + noteBounds.size.z > endCollider.transform.position.z)
            {
                if (!midiPlayer.MPTK_IsPlaying)
                {
                    start_time = Time.time - start_time;
                    midiPlayer.MPTK_Play();
                    midiPlayer.MPTK_ChannelVolumeSet(song.channel, 0.0f);
                    //midiPlayer.MPTK_ChannelVolumeSet(0, 0.0f);

                }

                //DEBUG
                var y = note.transform.position.y;
                float newFreq = fromHeightToFreq(y);

                frequency1 = ((int)(newFreq / 20)) * 20.0f;
                //

                if (!audioSource.isPlaying)
                {
                    //DEBUG
                    audioSource.Play();
                    //
                }
                note.transform.localScale -= new Vector3(0, 0, 0.02f);
               
                
                if (note.transform.localScale.z < 0)
                {
                    //DEBUG
                    audioSource.Stop();
                    //
                    playingNotes.RemoveAt(i);
                    Destroy(note);
                }

            }
        }

    }
}
