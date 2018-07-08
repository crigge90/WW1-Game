using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

    [SerializeField]
    Camera RoomCamera;

    
    public bool cameraActivation = false;
    public RoomData data;

	void Start ()
    {
        if (data.isStartingRoom == true)
        {
            cameraActivation = true;
        }
        if (cameraActivation == true)
        {
            RoomCamera.gameObject.SetActive(cameraActivation);
        } 
    }

    public void SetRoomActive(bool state)
    {
        gameObject.SetActive(state);
    }
}
