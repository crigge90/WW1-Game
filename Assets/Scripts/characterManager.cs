using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public int health;
    public string healthStatus;
    public enum Nationality {british, french, belgian, german}
    
    public enum Trauma {bulletTorso, bulletLeg, bulletArm, shrapnelTorso, shrapnelLeg, shrapnelArm, infectionTorso, infectionLeg, infectionArm}
    Trauma trauma;
    
    public Nationality PlayerNationality
    {
        get; set;
    }

    public Trauma PlayerTrauma
    {
        get; set;
    }
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

        int nationalityResult = UnityEngine.Random.Range(0, (int)Enum.GetValues(typeof(Nationality)).Length);
        Debug.Log(nationalityResult);
        PlayerNationality = (Nationality)nationalityResult;
        int traumaResult = UnityEngine.Random.Range(0, (int)Enum.GetValues(typeof(Trauma)).Length);
        PlayerTrauma = (Trauma)traumaResult;
        health = 49;
        Health();
	}
}
