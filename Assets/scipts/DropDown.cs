using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{

    

    public void HandleInputData(int val)
    {
         for(int i=1; i <= 90; i++ )
         {

               if (val == i)
                {
                  select_song.songNo = i-1;
                  music.musicURL = "seletedSong";
                }
        
      }
       

     }
}
