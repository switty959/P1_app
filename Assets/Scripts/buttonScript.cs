using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour {

    public Button[] buttons;
    public pointerCounter pointcounter;
    public GameObject[] panels;

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
  
}
