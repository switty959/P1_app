using UnityEngine;
using System.Diagnostics;

namespace RockVR.Video.Demo
{
    public class VideoCaptureUI : MonoBehaviour
    {
        public int[] pos = new int[4];
        public buttonScript buttons;
        public pointerCounter pointChecker;
        private void Awake()
        {
            Application.runInBackground = true;
        }

        private void OnGUI()
        {
            if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.NOT_START)
            {
                if (GUI.Button(new Rect(pos[0], pos[1], pos[2], pos[3]), "Start Capture"))
                {
                    VideoCaptureCtrl.instance.StartCapture();
                    buttons.panels[0].SetActive(true);
                    buttons.panels[1].SetActive(false);
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.STARTED )
            {
                if (GUI.Button(new Rect(pos[0], pos[1], pos[2], pos[3]), "Stop Capture"))
                {
                    VideoCaptureCtrl.instance.StopCapture();
                }
                if (pointChecker.exerciseFinish)
                {
                    VideoCaptureCtrl.instance.StopCapture();
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.STOPPED)
            {
                if (GUI.Button(new Rect(pos[0], pos[1], pos[2], pos[3]), "Processing"))
                {
                    // Waiting processing end.
                }
            }
           
        }
    }
}