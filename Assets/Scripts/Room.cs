using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

    [SerializeField]
    Camera RoomCamera;
    public GameObject BackgroundCanvas;
    Image image;
    Text text;

    public RoomData data;
    public bool isStartingRoom = false;
    

	void Start ()
    {
        //The room is built here
        //Components of the room is set to not active by defult
        RoomCamera.gameObject.SetActive(false);
        image = BackgroundCanvas.GetComponentInChildren<Image>();
        image.sprite = data.background;
        text = BackgroundCanvas.GetComponentInChildren<Text>();
        text.text = data.Name;
        BackgroundCanvas.gameObject.SetActive(false);
        
        //Checks if this room is starting room
        isStartingRoom = data.isStartingRoom;
        //Sets components active if it is starting room
        if (isStartingRoom == true)
        {
            RoomCamera.gameObject.SetActive(true);
            BackgroundCanvas.gameObject.SetActive(true);
        }
    }
}
