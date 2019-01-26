using System;
using UnityEngine;

namespace Application
{
    [CreateAssetMenu(menuName = "PluggableAI/State")]
    public class State : ScriptableObject
    {
        public Action[] actions;
        public Transition[] transitions;

        public void UpdateState(StateController stateController)
        {
            DoActions(stateController);
            MakeDecisions(stateController);
        }

        public void DoActions(StateController stateController)
        {
            for (int i = 0; i < actions.Length; i++)
            {
                actions[i].Act(stateController);
            }
        }

        public void MakeDecisions(StateController stateController)
        {
            for (int i = 0; i < transitions.Length; i++)
            {
                bool decisionSucceeded = transitions[i].decision.Decide(stateController);

                if (decisionSucceeded)
                {
                    stateController.TransitionToState(transitions[i].trueState);
                }
                else
                {
                    stateController.TransitionToState(transitions[i].falseState);
                }
            }
        }
    }
}
