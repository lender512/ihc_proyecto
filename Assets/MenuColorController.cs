using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;

public class MenuColorController : MonoBehaviour
{

    static public Color selectedColor;

    public List<Color> colors;

    public int selectedColorId = 0;

    public GameObject thereminPreview;
    public GameObject thereminBox;

    public List<string> names;

    public GameObject colorName;

    public GameObject leftArrow;

    public GameObject rightArrow;

    private AudioSource audioSource;

    public AudioClip clickClip;

    public AudioClip enterClip;

    public AudioClip exitClip;

    private int size = 0;


    void Start(){
        ChangeColor();
        size = names.Count;
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = enterClip;
    }

    public void PrevColor(){
        bool first = selectedColorId == 0;
        if(first){
            selectedColorId = size-1;
        }else{
            selectedColorId--;
        }
        ChangeColor();
        audioSource.PlayOneShot(clickClip);
    }
    public void NextColor(){
        selectedColorId = (selectedColorId+1)%size;
        ChangeColor();
        audioSource.PlayOneShot(clickClip);
    }

    public void PickColor(){
    }

    private void ChangeColor(){
        colorName.GetComponent<TextMeshProUGUI>().text = names[selectedColorId];
        selectedColor = colors[selectedColorId];
        thereminPreview.GetComponent<Renderer>().material.color = selectedColor;
    }

    public void ScaleLeft()
    {
        // Change scale to 1.1
        leftArrow.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        audioSource.PlayOneShot(enterClip);
    }

    public void ResetLeftScale()
    {
        // Set scale back to 1
        leftArrow.transform.localScale = Vector3.one;
        audioSource.PlayOneShot(exitClip);
    }

    public void ScaleRight()
    {
        // Change scale to 1.1
        rightArrow.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        audioSource.PlayOneShot(enterClip);
    }

    public void ResetRightScale()
    {
        // Set scale back to 1
        rightArrow.transform.localScale = Vector3.one;
        audioSource.PlayOneShot(exitClip);
    }

    public float rotationSpeed = 10f;
    
    void Update(){
        // Obtener la rotación actual del objeto
        Vector3 currentRotation = thereminBox.transform.rotation.eulerAngles;

        // Incrementar el ángulo de rotación en el eje Y
        float newRotationY = currentRotation.y + (rotationSpeed * Time.deltaTime);

        // Crear una nueva rotación a partir del ángulo actualizado
        Quaternion newRotation = Quaternion.Euler(currentRotation.x, newRotationY, currentRotation.z);

        // Aplicar la nueva rotación al objeto
        thereminBox.transform.rotation = newRotation;
    }

}
