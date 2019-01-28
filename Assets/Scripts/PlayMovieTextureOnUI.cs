using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://docs.unity3d.com/ScriptReference/WebCamTexture.Play.html reference link

public class PlayMovieTextureOnUI : MonoBehaviour
{
    public RawImage rawimage;
    public WebCamTexture webcamTexture;
    public Texture texture;
    void Start()
    {
        webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
    public void stopRenderWebcam()
    {
        webcamTexture.Stop();
        rawimage.material.mainTexture = texture;
    }
    public void startRenderWebcam()
    {
        webcamTexture.Play();
    }
}
