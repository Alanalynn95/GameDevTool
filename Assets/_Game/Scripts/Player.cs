using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int coins = 500;

    public QuestInfo NewQuest;


    public void Stats()
    {
        health -= 2;
        coins += 5;
    }

}
