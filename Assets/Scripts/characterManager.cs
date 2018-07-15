using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public int health;
    public string healthStatus;
    public CharacterData playerData;
    public CharacterData.Nation playerNationality;
    public CharacterData.Trauma playerTrauma;
    public CharacterData.Demonym playerDemonym;
    public Sprite[] playerAvatarList;
    public int avatarResult;
    public Sprite playerAvatarContainer;

    public void Health ()
    {

        if (health == 100)
        {
            healthStatus = "Healthy";
        }
        if (health <= 80)
        {
            healthStatus = "Trauma";
        }
        if (health <= 50)
        {
            healthStatus = "Serious trauma";
        }
        if (health <= 20)
        {
            healthStatus = "Deadly trauma";
        }
    }

	void Awake ()
    {
        playerNationality = (CharacterData.Nation)UnityEngine.Random.Range(0, Enum.GetValues(typeof(CharacterData.Nation)).Length - 1);
        playerDemonym = (CharacterData.Demonym)playerNationality;
        avatarResult = (int)playerNationality;
        playerAvatarContainer = playerAvatarList[avatarResult];
        playerTrauma = (CharacterData.Trauma)UnityEngine.Random.Range(1, Enum.GetValues(typeof(CharacterData.Trauma)).Length);
        health = 49;
        Health();
	}
}
