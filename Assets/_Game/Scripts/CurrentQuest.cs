using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentQuest : MonoBehaviour
{
    public QuestInfo NewQuest;

    public Text nameText;

    void Start()
    {
        nameText.text = NewQuest._questName;
    }
}
