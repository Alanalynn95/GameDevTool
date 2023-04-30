using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public QuestInfo NewQuest;

    public Player player;

    public GameObject questWindow;
    public GameObject currentQuest;

    public Text titleText;
    public Text descriptionText;
    public Text rewardText;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        titleText.text = NewQuest._questName;
        descriptionText.text = NewQuest._description;
        rewardText.text = NewQuest._reward;
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        currentQuest.SetActive(true);
        NewQuest.isActive = true;
        player.NewQuest = NewQuest;

    }
    public void DeclineQuest()
    {
        questWindow.SetActive(false);
        NewQuest.isActive = false;
    }

    public void CloseWindow()
    {
        questWindow.SetActive(false);
        NewQuest.isActive = false;
    }

}
