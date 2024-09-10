using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    //�ʒu����
    public class StatePositioning:PlayerStateBase
    {
        public override void OnEnter(Player owner, PlayerStateBase prevState)
        {
            owner.moveTime.ResetMoveTime();
            owner.putFoot.SwitchFoot();//�������ւ���
        }

        public override void OnUpdate(Player owner)
        {
            owner.move.MoveControl();

            if(!owner.moveTime.CanMove())//�����Ȃ��Ȃ�����ʒu���߂̌�ɑJ��
            {
                owner.ChangeState(stateAfterPositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
           
        }
    }
}
