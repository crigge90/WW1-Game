using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public Room RoomPrefab;
    public GameObject CurrentRoom = null;

    Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    void AddRoom(string name)
    {
        Room r = GameObject.Instantiate<Room>(RoomPrefab);
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
        // Frontline rooms
        AddRoom("Trench A");
        AddRoom("Trench B");
        AddRoom("Trench C");
        AddRoom("Trench D");
        AddRoom("HQ Dugout");
        AddRoom("Machine Gun Nest");
        AddRoom("Listening Post");
        AddRoom("No Mans Land");

        // Hospital rooms
        AddRoom("Room A");
        AddRoom("Room B");
        AddRoom("Hallway");
        AddRoom("Courtyard");
        AddRoom("Doctors Office");
        AddRoom("Garden");
        AddRoom("Operating Theatre");
        AddRoom("Nurse Quarters");

        // Frontline nightmare rooms
        AddRoom("Night Trench A");
        AddRoom("Night Trench B");
        AddRoom("Night Trench C");
        AddRoom("NIght Trench D");
        AddRoom("Night HQ Dugout");
        AddRoom("Night Machine Gun Nest");
        AddRoom("Night Listening Post");
        AddRoom("Night No Mans Land");

        SetActiveRoom(rooms["Start"]);
        
        
        // Turning current rooms camero on and all others off
        if (CurrentRoom == this)
        {
            //Some way to access the Room script and its getter and setter
        }
    }


    void Update ()
    {
		
	}
}
