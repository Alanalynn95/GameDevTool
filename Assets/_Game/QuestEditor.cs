using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class QuestEditor : MonoBehaviour
{

    public QuestDataS quest;

    public Text nameText;
    public Text descriptionText;
    public Text rewardText;

    void Start()
    {
        nameText.text = quest._questName;
        descriptionText.text = quest._description;
        rewardText.text = quest._reward;
    }


}
