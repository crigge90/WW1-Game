using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public RoomData[] Rooms;
    public Room RoomPrefab;

    void Start ()
    {
        for (int i = 0; i < Rooms.Length; i++)
        {
            var roomArray = Rooms[i].Name;
            Instantiate<Room>(RoomPrefab);
            RoomPrefab.data = Rooms[i];
            

            Debug.Log("Room " + roomArray + " created");
        }
    }

    void Update ()
    {
		
	}
}
