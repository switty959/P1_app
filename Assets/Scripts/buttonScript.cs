using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {

    public Button[] buttons;
    public pointerCounter pointcounter;
    public GameObject[] panels;
    public GameObject[] pages;

    // Use this for initialization	

    public void startExercise()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        panels[1].SetActive(true);
    }
    public void stopExercise()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(true);
        panels[1].SetActive(true);
        RockVR.Video.VideoCaptureCtrl.instance.StopCapture();
    }
    public void startRecording()
    {
        RockVR.Video.VideoCaptureCtrl.instance.StartCapture();
        panels[0].SetActive(true);
        panels[1].SetActive(true);
        panels[1].SetActive(true);
        pointcounter.recordingStarted = true;
    }
    public void changePage(int id)
    {
        RockVR.Video.VideoCaptureCtrl.instance.StartCapture();
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
        }
        pages[id].SetActive(true);
    }
    public void exitApp()
    {
        Application.Quit();
    }

}
