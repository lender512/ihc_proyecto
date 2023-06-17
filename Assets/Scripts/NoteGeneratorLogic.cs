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

    void Start()
    {
        GameObject newNote = Instantiate(note);
        var bounds = newNote.GetComponent<MeshRenderer>().bounds;
        newNote.transform.position = endCollider.transform.position - new Vector3(bounds.size.x / 2, bounds.size.y / 2, -3);
        //Destroy(newNote, 5);
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
            newNote.transform.position = endCollider.transform.position +
                new Vector3(-noteBounds.size.x / 2, noteBounds.size.y / 2, -3)
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

        foreach (var note in notes)
        {
            
        }

        for (int i = notes.Count - 1; i >= 0; i--)
        {
            var note = notes[i];

            var colliderBounds = endCollider.GetComponent<MeshRenderer>().bounds;
            var noteBounds = note.GetComponent<MeshRenderer>().bounds;

            if (note.transform.position.z + noteBounds.size.z > endCollider.transform.position.z)
            {
                note.transform.localScale -= new Vector3(0, 0, 0.02f);
                
                if (note.transform.localScale.z < 0)
                {
                    notes.RemoveAt(i);
                    Destroy(note);
                }

            }
        }

    }
}
