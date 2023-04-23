using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quest")]
public class QuestData : ScriptableObject
{
    [Header("Quest Info")]
    public string _questName;

    public string _description;

    public string _goal;

    [Header("Sound Effects")]

    public AudioSource _AcceptSound;

    public AudioSource _DeclineSound;

}
