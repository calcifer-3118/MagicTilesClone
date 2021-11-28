using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tileaction : MonoBehaviour
{

    public SpriteRenderer color;
    public SpriteRenderer bgcolor;
    public int scoreval = 1;
    public Rigidbody2D rb;
    public float speed = 500f;


    Color color1;


    public AudioClip touchsound;

    private int i = 1;
    private bool isclicked;


    // Start is called before the first frame update
    void Start()
    {
        isclicked = false;

        ColorUtility.TryParseHtmlString("#202124", out color1);

    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity =new Vector3(0f, -speed*Time.deltaTime, 0f);
        if(FindObjectOfType<score>().scoree > i*10)
        {
            speed += 20;
            i++;
        } 
       
    }

    



    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        { 
            if(isclicked==false){
            Debug.Log(speed);
            AudioSource.PlayClipAtPoint(touchsound, transform.position);
            color.color = color1;
            FindObjectOfType<score>().scoreUpdate(scoreval*10);
            isclicked = true;
            }  
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(color.color == color1)
        {
            Debug.Log("fine");
        }
        else if(col.collider.tag == "destroyer")
        {
            FindObjectOfType<score>().scoree = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
