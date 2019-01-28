using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class P1implementation : MonoBehaviour {

    // Use this for initialization

    public GameObject[] panels;

    public void SceneChange (int id)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
       
        panels[id].SetActive(true); 
    }
	
	}

