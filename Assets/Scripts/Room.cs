using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

    [SerializeField]
    GameObject RoomCamera;

    public GameObject BackgroundCanvas;
    public bool cameraActivation = false;
	void Start ()
    {
        RoomCamera.SetActive(cameraActivation);
    }
    
    public void SetRoomActive(bool state)
    {
        gameObject.SetActive(state);
    }
    
}
