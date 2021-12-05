using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCutscene : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Cutscene.light = true;
    }
}
