using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour {

    public GameObject CharacterMenu;
    public CharacterManager playerManager;
    public Text playerMenuStats;
    void Start ()
    {
        Debug.Log(playerManager.PlayerNationality);
        Debug.Log(playerManager.PlayerTrauma);
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CharacterMenu.SetActive(!CharacterMenu.activeInHierarchy);
        }
        playerMenuStats.text = "Nationality:\n" + playerManager.PlayerNationality
                               + "\n\n" + "Health:\n" + playerManager.healthStatus + 
                               "\n\n Injury type:\n" + playerManager.PlayerTrauma;
    }
}
