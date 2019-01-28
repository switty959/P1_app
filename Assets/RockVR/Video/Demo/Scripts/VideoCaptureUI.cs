using UnityEngine;
using System.Diagnostics;

namespace RockVR.Video.Demo
{
    public class VideoCaptureUI : MonoBehaviour
    {
        public int[] pos = new int[4];
        public pointerCounter pointChecker;
        GUIStyle style = new GUIStyle();
        private void Awake()
        {
            Application.runInBackground = true;
        }
        private void Update()
        {
            pointChecker = GameObject.FindGameObjectWithTag("gamemananger").GetComponentInChildren<pointerCounter>();
        }
        private void OnGUI()
        {
            if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.NOT_START)
            {
                if (pointChecker.recordingStarted)
                {
                    VideoCaptureCtrl.instance.StartCapture();
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.STARTED )
            {
                if (pointChecker.exerciseFinish)
                {
                    VideoCaptureCtrl.instance.StopCapture();
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.STOPPED)
            {
                if (GUI.Button(new Rect(pos[0], pos[1], pos[2], pos[3]),"Processing"))
                {
                    // Waiting processing end.
                }
            }
        }
    }
}