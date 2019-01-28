using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestoryOnLoad : MonoBehaviour {

    public GameObject thisShit;
    private void Awake()
    {
        thisShit = gameObject;
        DontDestroyOnLoad(thisShit);
    }
}
