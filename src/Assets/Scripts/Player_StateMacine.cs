using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public�@partial class Player
{
    //��ԑJ�ڂ��Ǘ�
    private static readonly StatePositioning statePositioning = new StatePositioning();//�ʒu����
    private static readonly StateAfterPositioning stateAfterPositioning = new StateAfterPositioning();//�ʒu���߂̌�

    private PlayerStateBase currentState;

    //Start()����Ă�
    private void OnStart()
    {
        currentState = statePositioning;
        currentState.OnEnter(this,null);
    }

    //Update()����Ă�
    private void OnUpdate()
    {
        currentState.OnUpdate(this);
    }

    //��Ԃ�J�ڂ����鎞�ɌĂ�
    private void ChangeState(PlayerStateBase nextState)
    {
        currentState.OnExit(this, nextState);
        nextState.OnEnter(this,currentState);
        currentState = nextState;
    }
}
