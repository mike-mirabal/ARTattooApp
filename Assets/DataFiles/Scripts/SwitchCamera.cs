using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SwitchCamera : MonoBehaviour {

    // default to front camera
    private bool on = false;

    public void Switch() {

        // moved outside of conditional to avoid duplication
        CameraDevice.Instance.Stop();
        CameraDevice.Instance.Deinit();
        TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();

        // consider storing camera direction in a variable to move Init outside conditional as well
        if (on)
        {
            CameraDevice.Instance.Init(CameraDevice.CameraDirection.CAMERA_BACK);
        }
        else
        {
            CameraDevice.Instance.Init(CameraDevice.CameraDirection.CAMERA_FRONT);
        }

        // moved outside of conditional to avoid duplication
        CameraDevice.Instance.Start();
        TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
    }

}
