using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://docs.unity3d.com/ScriptReference/WebCamTexture.Play.html reference link

public class PlayMovieTextureOnUI : MonoBehaviour
{
    public RawImage rawimage;
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
