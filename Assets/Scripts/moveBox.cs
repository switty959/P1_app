using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBox : MonoBehaviour {

    public int[] xpos = {30,720};
    public int[] ypos = { -30, -700 };
    public int maxSpeed = 5;
    public int speed;
    int point = 1;
    public pointerCounter pointcounter;
    RectTransform rectbox;
    float currentYPos;
    Transform boxpos;

    void Start () {
        currentYPos = ypos[0];
        rectbox = gameObject.GetComponent<RectTransform>();
        rectbox.anchoredPosition = new Vector3(xpos[1], currentYPos, 0);
        speed = maxSpeed;
    }
    public void moveTheBox()
    {
        rectbox.anchoredPosition = new Vector3(xpos[1], currentYPos, 0);
        if (currentYPos < ypos[1] || currentYPos > ypos[0])
        {
            speed *= -1;
        }
        if (currentYPos > ypos[0])
        {
            pointcounter.addPoint(point);
        }
        currentYPos += speed;    
    }  
}
