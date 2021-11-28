using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class music : MonoBehaviour
{
   public AudioSource musicSource;
    AudioClip clip;
    public static string musicURL;
    
    public Text errorMsg;
    
    private void Start()
    {
    
        StartCoroutine(DownloadMusic());

    }

    IEnumerator DownloadMusic()
    {
        UnityWebRequest request = UnityWebRequestMultimedia.GetAudioClip(musicURL, AudioType.MPEG);

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
            if(musicURL != "seletedSong")  { errorMsg.text = "Error fetching the music";   }
            StartCoroutine(DownloadMusic());        
        }
        else
        {
           

            clip = DownloadHandlerAudioClip.GetContent(request);
            musicSource.clip = clip;
            musicSource.Play();
        }
    }
}
