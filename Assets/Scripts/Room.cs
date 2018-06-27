using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

    [SerializeField]
    Camera RoomCamera;

    public GameObject BackgroundCanvas;
    public bool cameraActivation = false;
	void Start ()
    {
        RoomCamera.gameObject.SetActive(cameraActivation);
    }

    public void BuildRoom (RoomData data)
    {
        
    }
    
    public void SetRoomActive(bool state)
    {
        gameObject.SetActive(state);
    }
    
}
