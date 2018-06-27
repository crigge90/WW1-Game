using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public RoomData[] Rooms;
    public Room RoomPrefab;

    Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    public void AddRoom(RoomData roomData)
    {
        Room r = GameObject.Instantiate<Room>(RoomPrefab);
        r.BuildRoom(roomData);
        r.name = name;
        rooms.Add ( name, r );
    }

    void SetActiveRoom(Room r)
    {
        foreach (var item in rooms)
        {
            item.Value.SetRoomActive(false);
        }

        r.SetRoomActive(true);
    }
   
    void Start ()
    {
        
        for (int i = 0; i < Rooms.Length; i++)
        {
            AddRoom;
        }
        
        SetActiveRoom(rooms["Start"]);
    }


    void Update ()
    {
		
	}
}
