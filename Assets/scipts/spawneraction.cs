using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneraction : MonoBehaviour
{



    public float width = 10f;
    public float height = 10f;
    public float min = -5f;
    public float max = 10f;

    public GameObject tile;
    public float delay = 3f;


    // Start is called before the first frame update
    void Start()
    {
        spawnuntill();
    }


    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }



    // Update is called once per frame
    void Update()
    {
        if(checkforEmpty())
        {
            spawnuntill();
        }
        
    }


    void spawnuntill()
    {
        Transform position = freeposition();
        float random = Random.Range(min, max);
        Vector3 offset = new Vector3(0,random, 0);


        if(position){
            GameObject piano = Instantiate(tile, position.transform.position + offset, Quaternion.identity);
            piano.transform.parent = position;
        }
    
        if(freeposition())
        {
            Invoke("spawnuntill", delay);
        }

    }



    void spawner()
    {
        foreach(Transform child in transform)
        {
            GameObject piano = Instantiate(tile, child.position, Quaternion.identity);
            piano.transform.parent = child;
        }
    }


    bool checkforEmpty()
    {
         foreach(Transform child in transform)
        {
            if(child.childCount > 0){
                return false;
            }
            
        }

        return true;
    }

    Transform freeposition ()
    {
          foreach(Transform child in transform)
        {
            if(child.childCount == 0){
                return child;
            }
            
        }

        return null;
    }



}
