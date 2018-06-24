using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

    public GameObject RoomCamera;
    public GameObject BackgroundCanvas;
    public bool cameraActivation = false;
	void Start ()
    {
        RoomCamera.SetActive(false);
        if (cameraActivation == true)
        {
            RoomCamera.SetActive(true);
        }
    }

    public bool CameraActivation
    {
        get { return cameraActivation; }
        set { cameraActivation = value; }
    }
}
