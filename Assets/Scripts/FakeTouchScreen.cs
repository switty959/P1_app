using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeTouchScreen : MonoBehaviour {

    public int[] id = { 0,1};
    public pointerCounter pointer;
    public GameObject[] pagesOnExercisePart  = new GameObject[3];
    public sceneMananger mananger;
    public buttonScript buttons;
    public GameObject webcam;
    public GameObject homepageCode;

    private void Awake()
    {
        pointer = GetComponent<pointerCounter>();
        mananger = GetComponent<sceneMananger>();
        buttons = GetComponent<buttonScript>();
        webcam = GameObject.FindGameObjectWithTag("webcam");
        homepageCode = GameObject.FindGameObjectWithTag("pageCanvas");
    }
    
    // Update is called once per frame
    void Update () {
        Scene currentscene = SceneManager.GetActiveScene();
        int sceneID = currentscene.buildIndex;
        if (sceneID ==0)
        {
            hotKeysForHome();
        }
        if (sceneID == 1)
        {
            hotKeysForExercise();
        }
    }

    void hotKeysForHome()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            mananger.changeToExercise();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            homepageCode.GetComponent<P1implementation>().SceneChange(2);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            buttons.exitApp();
        }
    }
    void hotKeysForExercise()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pointer.recordingStarted = true;
            pointer.exerciseStarted = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            webcam.GetComponent<PlayMovieTextureOnUI>().stopRenderWebcam();
            buttons.changePage(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            webcam.GetComponent<PlayMovieTextureOnUI>().stopRenderWebcam();
            buttons.changePage(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            mananger.changeToHomePage();
        }
    }
}
