using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoMenu : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FinalCutscene.endGame = true;
    }
}
