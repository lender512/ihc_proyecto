using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class MenuScoreController : MonoBehaviour
{
    private const string baseUrl = "https://backend-project-ihc-mariorios-utecedupe.vercel.app/api/fetch_data";
    private const string songName = "luisChupameelNepe";

    void Start()
    {
        StartCoroutine(SendGetRequest());
    }

    private IEnumerator SendGetRequest()
    {
        // Create the request payload as a JSON string
        string jsonPayload = $"{{ \"songName\": \"{songName}\" }}";

        using (UnityWebRequest webRequest = UnityWebRequest.Post(baseUrl, jsonPayload))
        {
            // Set the content type header
            webRequest.SetRequestHeader("Content-Type", "application/json");

            // Send the request
            yield return webRequest.SendWebRequest();

            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Error sending request: " + webRequest.error);
            }
            else
            {
                // Process the response
                Debug.Log("Request successful");
                Debug.Log("Response: " + webRequest.downloadHandler.text);
            }
        }
    }
}
