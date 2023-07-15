using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.Networking;

[System.Serializable]
public class ScoreSingle
{
    public int id;
    public string username;
    public string songName;
    public double score;
    public string timestamp;

}


[System.Serializable]
public class ScoreChunk
{
    public ScoreSingle highscore;
    public List<ScoreSingle> mostRecents;
}


[System.Serializable]
public struct ScoreGameObjects
{
    public GameObject name;
    public GameObject score;
    public GameObject day;
}

public class MenuPlayController : MonoBehaviour
{
    
    private const string apiUrl = "https://backend-project-ihc-mariorios-utecedupe.vercel.app/api/fetch_data";
    
    public string songName ;
    
    public ScoreGameObjects[] scoreGameObjectsArray;
    

    static public SongScript selectedSongScript;

    public List<SongScript> songScripts;

    public int selectedSongId = 0;

    public GameObject banner;

    public List<Sprite> sprites;

    public GameObject nameSong;

    public GameObject leftArrow;

    public GameObject rightArrow;

    private AudioSource audioSource;

    public AudioClip clickClip;

    public AudioClip enterClip;

    public AudioClip exitClip;

    public AudioClip playClip;

    public GameObject scoreTitleSong;

    private int size = 0;

    public static string SplitPascalCase(string input) => string.Join(" ", Regex.Split(input, @"(?<!^)(?=[A-Z])"));


    void Start(){
        ChangeSong();
        size = sprites.Count;
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = enterClip;
    }

    public void PrevSong(){
        bool first = selectedSongId == 0;
        if(first){
            selectedSongId = size-1;
        }else{
            selectedSongId--;
        }
        ChangeSong();
        audioSource.PlayOneShot(clickClip);
    }
    public void NextSong(){
        selectedSongId = (selectedSongId+1)%size;
        ChangeSong();
        audioSource.PlayOneShot(clickClip);
    }

    public void PlaySong(){
        selectedSongScript = songScripts[selectedSongId];
        audioSource.PlayOneShot(playClip);
        SceneManager.LoadScene(1);
    }

    private void ChangeSong()
    {
        songName = songScripts[selectedSongId].GetType().Name;
        var name_splitted = SplitPascalCase(songName);
        nameSong.GetComponent<TextMeshProUGUI>().text = name_splitted;
        scoreTitleSong.GetComponent<TextMeshProUGUI>().text = name_splitted;
         banner.GetComponent<Image>().sprite = sprites[selectedSongId];
         StartCoroutine(ChangeScores());
         
    }
    
    private IEnumerator ChangeScores()
    {
        foreach(var scoreGameObjets in scoreGameObjectsArray)
        {
            scoreGameObjets.name.GetComponent<TextMeshProUGUI>().text = "----";
            scoreGameObjets.score.GetComponent<TextMeshProUGUI>().text = "----";
            scoreGameObjets.day.GetComponent<TextMeshProUGUI>().text = "----";
        }
        
        Debug.Log("Print2");

        
        // Create the request URL with parameters
        string url = $"{apiUrl}?songName={songName}";

        using (UnityWebRequest request = UnityWebRequest.Post(url ,""))
        {
            Debug.Log("Print1");
            // Set the content type header
            request.SetRequestHeader("Content-Type", "application/json");

            // Send the request and wait for a response
            yield return request.SendWebRequest();

            // Check for errors
            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Print2");
                Debug.LogError(request.error);
            }
            else
            {
                // Process the response data
                Debug.Log("Print3");
                var json = request.downloadHandler.text;
                ScoreChunk data = JsonUtility.FromJson<ScoreChunk>(json);
                if (data.mostRecents != null && data.mostRecents.Count > 0)
                {
                    scoreGameObjectsArray[0].name.GetComponent<TextMeshProUGUI>().text = data.highscore.username;
                    scoreGameObjectsArray[0].score.GetComponent<TextMeshProUGUI>().text = ((int) data.highscore.score).ToString() + "pts";
                    scoreGameObjectsArray[0].day.GetComponent<TextMeshProUGUI>().text = data.highscore.timestamp.Split('T')[0];

                    for (int i = 0; (i < data.mostRecents.Count) && (i < 4); ++i)
                    {
                        scoreGameObjectsArray[i+1].name.GetComponent<TextMeshProUGUI>().text = data.mostRecents[i].username;
                        scoreGameObjectsArray[i+1].score.GetComponent<TextMeshProUGUI>().text = ((int) data.mostRecents[i].score).ToString() + "pts";
                        scoreGameObjectsArray[i+1].day.GetComponent<TextMeshProUGUI>().text = data.mostRecents[i].timestamp.Split('T')[0];
                    }
                    
                }
            }
        }
    }

    public void ScaleBanner()
    {
        // Change scale to 1.1
        //banner.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        //audioSource.PlayOneShot(enterClip);
    }

    public void ResetBannerScale()
    {
        // Set scale back to 1
        //banner.transform.localScale = Vector3.one;
        //audioSource.PlayOneShot(exitClip);
    }

    public void ScaleLeft()
    {
        // Change scale to 1.1
        //leftArrow.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        //audioSource.PlayOneShot(enterClip);
    }

    public void ResetLeftScale()
    {
        // Set scale back to 1
        //leftArrow.transform.localScale = Vector3.one;
        //audioSource.PlayOneShot(exitClip);
    }

    public void ScaleRight()
    {
        // Change scale to 1.1
        //rightArrow.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        //audioSource.PlayOneShot(enterClip);
    }

    public void ResetRightScale()
    {
        // Set scale back to 1
        //rightArrow.transform.localScale = Vector3.one;
        //audioSource.PlayOneShot(exitClip);
    }

}
