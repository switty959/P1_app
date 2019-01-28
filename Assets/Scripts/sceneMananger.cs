using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMananger : MonoBehaviour {
    int[] scenes = {0,1};
    public GameObject webcam;
    void Awake()
    {
        webcam = GameObject.FindGameObjectWithTag("webcam");
    }

    public void changeToExercise()
    {
        SceneManager.LoadScene(scenes[1]);
    }
    public void changeToHomePage()
    {
        if (SceneManager.GetActiveScene().buildIndex == scenes[1])
        {
            webcam.GetComponent<PlayMovieTextureOnUI>().stopRenderWebcam();
        }
        
        SceneManager.LoadScene(scenes[0]);
    }
    


}
