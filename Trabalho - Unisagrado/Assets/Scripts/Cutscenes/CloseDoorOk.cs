using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorOk : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (FinalSugador.hasFinal == true)
        {
            FinalCutscene.finalOk = true;
        }
        else
        {
            Cutscene.rotateCannon = true;
        }          
    }
}
