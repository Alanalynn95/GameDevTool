using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class QuestEditor : MonoBehaviour
{

    public QuestInfo NewQuest;

    public Text nameText;
    public Text descriptionText;
    public Text rewardText;

    void Start()
    {
        nameText.text = NewQuest._questName;
        descriptionText.text = NewQuest._description;
        rewardText.text = NewQuest._reward;
    }


}
