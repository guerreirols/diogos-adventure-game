using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downOk : StateMachineBehaviour
{  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FinalCutscene.downOk = true;
    }
}
