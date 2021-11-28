using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_bg : MonoBehaviour
{


     private float nextActionTime = 0.0f; public float period = 0.1f;

    public Sprite[] Backgrounds; //this is an array of type sprite
 
     public SpriteRenderer Render; //this is a variable of type sprite renderer
 
     // Use this for initialization
     void Start () {

         }
     // Update is called once per frame
     void Update () {

            if (Time.time > nextActionTime ) 
      { 
            nextActionTime = Time.time + period; 
           // execute block of code here 
            Render = GetComponent<SpriteRenderer>(); 
            /*assigning the Render to the object's SpriteRender, this will allow us to access the image from 
            code*/
            Render.sprite = Backgrounds[Random.Range(0, Backgrounds.Length)]; 
            /*this will change the current sprite of the sprite renderer to a random sprite that was chosen 
            randomly from the array of backgrounds */
      } 
           
     }


}
