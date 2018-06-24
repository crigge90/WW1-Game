using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public GameObject RoomPrefab;
    public GameObject CurrentRoom = null;

    // Frontline rooms
    GameObject TrenchA;
    GameObject TrenchB;
    GameObject TrenchC;
    GameObject TrenchD;
    GameObject HQDugout;
    GameObject MachineGunNest;
    GameObject ListeningPost;
    GameObject NoMansLand;

    // Hospital rooms
    GameObject RoomA;
    GameObject RoomB;
    GameObject Hallway;
    GameObject Courtyard;
    GameObject DoctorsOffice;
    GameObject Garden;
    GameObject OperatingTheatre;
    GameObject NurseQuarters;

    // Frontline nightmare rooms
    GameObject NightTrenchA;
    GameObject NightTrenchB;
    GameObject NightTrenchC;
    GameObject NightTrenchD;
    GameObject NightHQDugout;
    GameObject NightMachineGunNest;
    GameObject NightListeningPost;
    GameObject NightNoMansLand;

    void Start ()
    {
        // Frontline rooms
        TrenchA = (GameObject)Instantiate(RoomPrefab, new Vector3(-6000, 0, 0), Quaternion.Euler(0, 0, 0));
        TrenchA.name = "Trench A";
        TrenchB = (GameObject)Instantiate(RoomPrefab, new Vector3(-3000, 0, 0), Quaternion.Euler(0, 0, 0));
        TrenchB.name = "Trench B";
        TrenchC = (GameObject)Instantiate(RoomPrefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        TrenchC.name = "Trench C";
        TrenchD = (GameObject)Instantiate(RoomPrefab, new Vector3(0, 1200, 0), Quaternion.Euler(0, 0, 0));
        TrenchD.name = "Trench D";
        HQDugout = (GameObject)Instantiate(RoomPrefab, new Vector3(3000, 0, 0), Quaternion.Euler(0, 0, 0));
        HQDugout.name = "HQ Dugout";
        MachineGunNest = (GameObject)Instantiate(RoomPrefab, new Vector3(-3000, 1200, 0), Quaternion.Euler(0, 0, 0));
        MachineGunNest.name = "Machine Gun Nest";
        ListeningPost = (GameObject)Instantiate(RoomPrefab, new Vector3(3000, 1200, 0), Quaternion.Euler(0, 0, 0));
        ListeningPost.name = "Listening Post";
        NoMansLand = (GameObject)Instantiate(RoomPrefab, new Vector3(0, 2400, 0), Quaternion.Euler(0, 0, 0));
        NoMansLand.name = "No Mans Land";

        // Hospital rooms
        RoomA = (GameObject)Instantiate(RoomPrefab, new Vector3(-26000, 0, 0), Quaternion.Euler(0, 0, 0));
        RoomA.name = "Room A";
        RoomB = (GameObject)Instantiate(RoomPrefab, new Vector3(-23000, 0, 0), Quaternion.Euler(0, 0, 0));
        RoomB.name = "Room B";
        Hallway = (GameObject)Instantiate(RoomPrefab, new Vector3(-20000, 0, 0), Quaternion.Euler(0, 0, 0));
        Hallway.name = "Hallway";
        Courtyard = (GameObject)Instantiate(RoomPrefab, new Vector3(-20000, 1200, 0), Quaternion.Euler(0, 0, 0));
        Courtyard.name = "Courtyard";
        DoctorsOffice = (GameObject)Instantiate(RoomPrefab, new Vector3(-17000, 0, 0), Quaternion.Euler(0, 0, 0));
        DoctorsOffice.name = "Doctors Office";
        Garden = (GameObject)Instantiate(RoomPrefab, new Vector3(-23000, 1200, 0), Quaternion.Euler(0, 0, 0));
        Garden.name = "Garden";
        OperatingTheatre = (GameObject)Instantiate(RoomPrefab, new Vector3(-17000, 1200, 0), Quaternion.Euler(0, 0, 0));
        OperatingTheatre.name = "Operating Theatre";
        NurseQuarters = (GameObject)Instantiate(RoomPrefab, new Vector3(-20000, 2400, 0), Quaternion.Euler(0, 0, 0));
        NurseQuarters.name = "Nurse Quarters";

        // Frontline nightmare rooms
        NightTrenchA = (GameObject)Instantiate(RoomPrefab, new Vector3(14000, 0, 0), Quaternion.Euler(0, 0, 0));
        NightTrenchA.name = "Night Trench A";
        NightTrenchB = (GameObject)Instantiate(RoomPrefab, new Vector3(17000, 0, 0), Quaternion.Euler(0, 0, 0));
        NightTrenchB.name = "Night Trench B";
        NightTrenchC = (GameObject)Instantiate(RoomPrefab, new Vector3(20000, 0, 0), Quaternion.Euler(0, 0, 0));
        NightTrenchC.name = "Night Trench C";
        NightTrenchD = (GameObject)Instantiate(RoomPrefab, new Vector3(20000, 1200, 0), Quaternion.Euler(0, 0, 0));
        NightTrenchD.name = "Night Trench D";
        NightHQDugout = (GameObject)Instantiate(RoomPrefab, new Vector3(23000, 0, 0), Quaternion.Euler(0, 0, 0));
        NightHQDugout.name = "Night HQ Dugout";
        NightMachineGunNest = (GameObject)Instantiate(RoomPrefab, new Vector3(17000, 1200, 0), Quaternion.Euler(0, 0, 0));
        NightMachineGunNest.name = "Night Machine Gun Nest";
        NightListeningPost = (GameObject)Instantiate(RoomPrefab, new Vector3(23000, 1200, 0), Quaternion.Euler(0, 0, 0));
        NightListeningPost.name = "Night Listening Post";
        NightNoMansLand = (GameObject)Instantiate(RoomPrefab, new Vector3(20000, 2400, 0), Quaternion.Euler(0, 0, 0));
        NightNoMansLand.name = "Night No Mans Land";

        //Starting Room
        CurrentRoom = TrenchB;

        // Turning curent rooms camero on and all others off
        if (CurrentRoom == this)
        {
            //Some way to access the Room script and its getter and setter
        }
    }


    void Update ()
    {
		
	}
}
