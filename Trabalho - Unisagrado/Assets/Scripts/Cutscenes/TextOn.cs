using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOn : StateMachineBehaviour
{    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(FinalSugador.hasFinal == true)
        {
            FinalCutscene.textOn = true;
        }
        else
        {
            EnemyChat.textOn = true;
        }      
    }   
}
