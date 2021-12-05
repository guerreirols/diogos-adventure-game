using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterOk : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (FinalSugador.hasFinal == true)
        {
            FinalCutscene.isEnter = true;
        }
        else
        {
            Cutscene.isEnter = true;
        }            
    }
}
