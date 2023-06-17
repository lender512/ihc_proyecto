using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float amplitude = 1f;     // Amplitude of the sine wave
    public float frequency = 1f;     // Frequency of the sine wave
    public float speed = 1f;         // Speed of movement
    private float startTime;         // Starting time of movement

    private void Start()
    {
        startTime = Time.time;       // Record the starting time
    }

    private void Update()
    {
        float deltaTime = Time.time - startTime;                         // Calculate the time since the movement started
        float xPos = Mathf.Sin(deltaTime * frequency) * amplitude;       // Calculate the x position using the sine function

        Vector3 newPosition = transform.position;                        // Get the current position
        newPosition.y += xPos * Time.deltaTime;                          // Move object vertically based on speed
        transform.position = newPosition;                                 // Update the position
    }
}
