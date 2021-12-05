using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFire : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Cutscene.endFire = true;
    }
}
