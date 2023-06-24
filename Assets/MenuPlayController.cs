using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPlayController : MonoBehaviour
{
    private int selectedSongId = 0;

    public GameObject banner;

    public List<Sprite> sprites;

    private int size = 0;

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
        SceneManager.LoadScene(1);
    }

    private void ChangeSong(){
         banner.GetComponent<Image>().sprite = sprites[selectedSongId];
    }

    
}
