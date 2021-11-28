using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_song : MonoBehaviour
{

    public AudioClip[] songs;
    public AudioSource source;

    public static int songNo;


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = songs[songNo];
        source.Play();
    }

   
}
