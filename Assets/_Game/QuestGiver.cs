using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public QuestDataS quest;

    public Player player;

    public GameObject questWindow;

    public Text titleText;
    public Text descriptionText;
    public Text rewardText;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        titleText.text = quest._questName;
        descriptionText.text = quest._description;
        rewardText.text = quest._reward;
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        player.quest = quest;
    }
}
