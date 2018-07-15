using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Character Data", menuName = "Character Asset")]
public class CharacterData : ScriptableObject
{
    public enum Nation { unitedKingdom, france, belgium, germany, austriaHungary, italy, switzerland }
    public enum Demonym { british, french, belgian, german, austroHungarian, italian, swiss }
    public enum Rank { civilian, soldier, corporal, sergeant, lieutenant, captain }
    public enum Profession { infantryman, officer, nurse, doctor }
    public enum Trauma { none, bulletTorso, bulletLeg, bulletArm, shrapnelTorso, shrapnelLeg, shrapnelArm, infectionTorso, infectionLeg, infectionArm }

    public bool isPlayer;
    public string firstName;
    public string lastName;
    public Nation characterNation;
    public Demonym characterDemonym;
    public Rank characterRank;
    public Profession CharacterProfession;
    public Trauma characterTrauma;
    public Sprite menuAvatar;
}
