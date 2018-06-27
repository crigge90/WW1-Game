using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Room Data", menuName = "Room Asset")]
public class RoomData : ScriptableObject
{
    public string Name;
    public Sprite background;
    public RoomData[] neighbours;
    public bool isStartingRoom = false;
}
