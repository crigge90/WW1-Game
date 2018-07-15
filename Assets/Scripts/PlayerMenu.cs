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
    public Image playerAvatar;
    void Start ()
    {
        
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CharacterMenu.SetActive(!CharacterMenu.activeInHierarchy);
            PlayerAvatar.SetActive(!PlayerAvatar.activeInHierarchy);
        }
        playerMenuNationalityStat.text = "" + playerManager.playerDemonym;
        playerMenuHealthStat.text = "" + playerManager.healthStatus;
        playerMenuTraumaStat.text = "" + playerManager.playerTrauma;
        PlayerAvatar.GetComponent<Image>().sprite = playerManager.playerAvatarContainer;
    }
}
