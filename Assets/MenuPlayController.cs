using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;

public class MenuPlayController : MonoBehaviour
{

    static public SongScript selectedSongScript;

    public List<SongScript> songScripts;

    public int selectedSongId = 0;

    public GameObject banner;

    public List<Sprite> sprites;

    public GameObject nameSong;

    public GameObject leftArrow;

    public GameObject rightArrow;

    private int size = 0;

    public static string SplitPascalCase(string input) => string.Join(" ", Regex.Split(input, @"(?<!^)(?=[A-Z])"));


    void Start(){
        ChangeSong();
        Debug.Log("HOLAA");
        size = sprites.Count;
    }

    public void PrevSong(){
        bool first = selectedSongId == 0;
        if(first){
            selectedSongId = size-1;
        }else{
            selectedSongId--;
        }
        ChangeSong();
    }
    public void NextSong(){
        selectedSongId = (selectedSongId+1)%size;
        ChangeSong();
    }

    public void PlaySong(){
        selectedSongScript = songScripts[selectedSongId];
        SceneManager.LoadScene(1);
    }

    private void ChangeSong(){
        nameSong.GetComponent<TextMeshProUGUI>().text = SplitPascalCase(songScripts[selectedSongId].GetType().Name);
         banner.GetComponent<Image>().sprite = sprites[selectedSongId];
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
