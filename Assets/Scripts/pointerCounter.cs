using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointerCounter : MonoBehaviour {
    public int points = -1;
    public int numOfAction = 2;
    public GameObject[] panels = new GameObject[2];
    public moveBox movingbox;
    string[] textForExercise = new string[3];
    public bool exerciseStarted, exerciseFinish, exercisePaused = false;
    void Awake()
    {
        textForExercise[0] = "do this exercise " + numOfAction + " times \n" +
                             "hover your hand on the red box to start the exercise";
        textForExercise[1] = "Well done!";
        textForExercise[2] = "keep it up";
        panels[1].SetActive(false);
        
    }

    void Update()
    {
        panels[1].GetComponentInChildren<Text>().text = points + " / " + numOfAction;
        panels[0].GetComponentInChildren<Text>().text = textForExercise[0];
        if (exerciseStarted)
        {
            movingbox.moveTheBox();
            panels[1].SetActive(true);
            panels[0].SetActive(false);
        }

        if (points == numOfAction)
        {
            changeText();
            movingbox.speed = 0;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            exerciseStarted = true;
        }
    }

    public void addPoint(int addition)
    {
        points++;
    }
    public void changeText()
    {
        panels[1].SetActive(false);
        panels[0].SetActive(true);
        panels[0].GetComponentInChildren<Text>().text = textForExercise[1];
    }
}
