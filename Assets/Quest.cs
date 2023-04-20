using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : ScriptableObject
{
    [System.Serializable]
    public struct Info
    {
        public string Name;
        public Sprite Icon;
        public string Description;
    }

    [Header("Info")] public Info Information;

    [System.Serializable]
    public struct Stat
    {
        public int Currency;
        public int XP;
    }

    [Header("Reward")] public Stat Reward = new Stat { Currency = 10, XP = 10 };
    
    public bool Completed { get; private set; }
    //public QuestCompletedEvent QuestCompleted;

    public abstract class QuestGoal : ScriptableObject
    {
        protected string Description;
        public int CurrentAmount { get; protected set; }
        public int RequiredAmount = 1;

        public bool Completed { get; protected set; }
        //{HideInInspector] public UnityEvent GoalCompleted;

        public virtual string GetDescription()
        {
            return Description;
        }

        public virtual void Initialize()
        {
            Completed = false;
           // GoalCompleted = new UnityEvent();
        }

        protected void Evalute()
        {
            if(CurrentAmount >= RequiredAmount)
            {
                Complete();
            }
        }

        private void Complete()
        {
            Completed = true;
           // GoalCompleted.Invoke();
           // GoalCompleted.RemoveAllListeners();
        }

        
    }

    public List<QuestGoal> Goals;

    public void Initialize()
    {
        Completed = false;
    }

}

//public class QuestCompletedEvent : UnityEvent<Quest> { }
