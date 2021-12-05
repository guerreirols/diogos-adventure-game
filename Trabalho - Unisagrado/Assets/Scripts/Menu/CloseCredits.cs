using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCredits : StateMachineBehaviour
{
    public static bool hasFinished = false;
  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        hasFinished = !hasFinished;
    }
}
