using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Cutscene.rotateCam = true;
    }
}
