using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class pointerCounter : MonoBehaviour
    {
        public int points = -1;
        public int numOfAction = 2;
        public float currentSpeed;
        public GameObject[] panels = new GameObject[2];
        public moveBox movingbox;
        public Animator rightarm;
        public float animationSpeed,animationCurrentSpeed;

        string[] textForExercise = new string[3];
        public bool exerciseStarted, exerciseFinish, exercisePaused,recordingStarted = false;
        void Awake()
        {
            textForExercise[0] = "do this exercise " + numOfAction + " times. \n" +
                                 "Match your body to \n" +
                                 "the outline of darken body.\n" +
                                 "To start the exercise, \n" +
                                 "stay for 3 seconds";
            textForExercise[1] = "Well done!";
            textForExercise[2] = "keep it up";
            panels[1].SetActive(false);
            animationSpeed = rightarm.speed;
            animationCurrentSpeed = animationSpeed;
            currentSpeed = movingbox.speed;
            rightarm.speed = 0;

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
            rightarm.speed = animationCurrentSpeed;
            }
            if (points == numOfAction)
            {
                changeText();
                movingbox.speed = 0;
                exerciseFinish = true;
            }
            if (exerciseFinish)
            {
                // tilbage til overview og tilføj procent til måler
                panels[1].SetActive(true);
                panels[0].SetActive(false);
                rightarm.speed = 0;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && !exerciseStarted) // to start exercise
            {
                exerciseStarted = true;
                animationCurrentSpeed = animationSpeed;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)) // to pause
            {
                animationCurrentSpeed = 0;
                movingbox.speed = 0;
                exercisePaused = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && exercisePaused) // to resume
            {
                animationCurrentSpeed = animationSpeed;
                movingbox.speed = currentSpeed;
                exercisePaused = false;
            }
        }

        public void addPoint(int addition)
        {
            points++;
        }
        public void changeText()
        {
            panels[1].SetActive(true);
            panels[0].SetActive(true);
            panels[0].GetComponentInChildren<Text>().text = textForExercise[1];
        }
}
