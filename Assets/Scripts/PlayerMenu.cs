﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour {

    public GameObject CharacterMenu;
    public CharacterManager playerManager;
    public Text playerMenuNationalityStat;
    public Text playerMenuHealthStat;
    public Text playerMenuTraumaStat;
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
        playerMenuNationalityStat.text = "" + playerManager.PlayerNationality;
        playerMenuHealthStat.text = "" + playerManager.healthStatus;
        playerMenuTraumaStat.text = "" + playerManager.PlayerTrauma;
    }
}
