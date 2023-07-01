using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;

public class MenuColorController : MonoBehaviour
{

    static public Texture selectedColorTexture;

    public List<Texture> textures;

    public int selectedColorId = 0;

    public GameObject banner;

    public List<string> names;

    public List<Sprite> sprites;

    public GameObject colorName;

    public GameObject leftArrow;

    public GameObject rightArrow;

    private int size = 0;


    void Start(){
        ChangeColor();
        size = sprites.Count;
    }

    public void PrevColor(){
        bool first = selectedColorId == 0;
        if(first){
            selectedColorId = size-1;
        }else{
            selectedColorId--;
        }
        ChangeColor();
    }
    public void NextColor(){
        selectedColorId = (selectedColorId+1)%size;
        ChangeColor();
    }

    public void PickColor(){
    }

    private void ChangeColor(){
        colorName.GetComponent<TextMeshProUGUI>().text = names[selectedColorId];
        banner.GetComponent<Image>().sprite = sprites[selectedColorId];
        selectedColorTexture = textures[selectedColorId];
    }

    public void ScaleBanner()
    {
        // Change scale to 1.1
        banner.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void ResetBannerScale()
    {
        // Set scale back to 1
        banner.transform.localScale = Vector3.one;
    }

    public void ScaleLeft()
    {
        // Change scale to 1.1
        leftArrow.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void ResetLeftScale()
    {
        // Set scale back to 1
        leftArrow.transform.localScale = Vector3.one;
    }

    public void ScaleRight()
    {
        // Change scale to 1.1
        rightArrow.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void ResetRightScale()
    {
        // Set scale back to 1
        rightArrow.transform.localScale = Vector3.one;
    }

}
