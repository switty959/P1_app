using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointerCounter : MonoBehaviour {
    public int points = 0;
    public int numOfAction = 7;
    public Text textfield;

    void Update()
    {
        textfield.text = points +" / "+numOfAction;
    }

    public void addPoint(int addition)
    {
        points++;
    }
}
