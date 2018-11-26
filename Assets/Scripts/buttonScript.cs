using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Media;

public class buttonScript : MonoBehaviour {

    public Button[] buttons;
    public pointerCounter pointcounter;
    public GameObject[] panels;
    public string path = ("");
    public VideoTrackAttributes webcamfeed;
    // Use this for initialization	

    public void startExercise()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
    }
    public void stopExercise()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(true);
    }
    public void startRecording()
    {
      
        
    }
}
