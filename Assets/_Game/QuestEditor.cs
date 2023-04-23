using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestEditor : MonoBehaviour
{
    public QuestData quest;

    public Text nameText;
    public Text descriptionText;
    public Text goalText;

    void Start()
    {
        nameText.text = quest._questName;
        descriptionText.text = quest._description;
        goalText.text = quest._goal;
    }


}
