using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour {

    public GameObject CharacterMenu;
    public GameObject PlayerAvatar;
    public CharacterManager playerManager;
    public Text playerMenuNationalityStat;
    public Text playerMenuHealthStat;
    public Text playerMenuTraumaStat;
    public Sprite playerAvatar;
    void Start ()
    {
        if (playerManager.PlayerNationality == CharacterManager.Nationality.british)
        {
            PlayerAvatar.GetComponent<Image>().sprite = playerManager.AvatarSoldierBritish;
        }
        if (playerManager.PlayerNationality == CharacterManager.Nationality.french)
        {
            PlayerAvatar.GetComponent<Image>().sprite = playerManager.AvatarSoldierFrench;
        }
        if (playerManager.PlayerNationality == CharacterManager.Nationality.belgian)
        {
            PlayerAvatar.GetComponent<Image>().sprite = playerManager.AvatarSoldierBelgian;
        }
        if (playerManager.PlayerNationality == CharacterManager.Nationality.german)
        {
            PlayerAvatar.GetComponent<Image>().sprite = playerManager.AvatarSoldierGerman;
        }
        if (playerManager.PlayerNationality == CharacterManager.Nationality.austrohungarian)
        {
            PlayerAvatar.GetComponent<Image>().sprite = playerManager.AvatarSoldierAustrohungarian;
        }
        if (playerManager.PlayerNationality == CharacterManager.Nationality.italian)
        {
            PlayerAvatar.GetComponent<Image>().sprite = playerManager.AvatarSoldierItalian;
        }

        Debug.Log(playerManager.PlayerNationality);
        Debug.Log(playerManager.PlayerTrauma);
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CharacterMenu.SetActive(!CharacterMenu.activeInHierarchy);
            PlayerAvatar.SetActive(!PlayerAvatar.activeInHierarchy);
        }
        playerMenuNationalityStat.text = "" + playerManager.PlayerNationality;
        playerMenuHealthStat.text = "" + playerManager.healthStatus;
        playerMenuTraumaStat.text = "" + playerManager.PlayerTrauma;
    }
}
