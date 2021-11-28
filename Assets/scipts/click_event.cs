using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class click_event : MonoBehaviour
{


    public float final_progress;
   
    public GameObject loadingScreen;
    public Slider slider;


 

    public void LoadMainScene(int sceneIndex)
    {

       score.scorepoints = 0;
       loadingScreen.SetActive(true);
       StartCoroutine(LoadAsynchronously(sceneIndex));
               
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while(operation.isDone == false)
        {
            final_progress = operation.progress;
            Debug.Log(operation.progress);

            yield return null;
        }

       
        
        
    }

  void Update()
        {
            if(final_progress < 0.9)
            {
            
                slider.value = Mathf.MoveTowards(slider.value, final_progress, 3*Time.deltaTime);

            }
            else if(final_progress == 0.9)
            {
                slider.value = 1;
            }
        
        }
            
        


}