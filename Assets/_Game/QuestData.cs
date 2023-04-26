using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "New Quest", menuName = "Quest")]
    public class QuestDataS : ScriptableObject
    {
        public bool isActive;

        [Header("Quest Info")]
        public string _questName;

        public string _description;

        public string _reward;

        [Header("Sound Effects")]

        public AudioSource _AcceptSound;

        public AudioSource _DeclineSound;

    [Header("Quest Goal")]

    public GoalType _goalType;

    public int _requiredAmount;

    public int _currentAmount;

    public bool IsReached()
    {
    return (_currentAmount >= _requiredAmount);
     }

    public enum GoalType
     {
     Kill,
     Gathering,
    Crafting
     }


}


