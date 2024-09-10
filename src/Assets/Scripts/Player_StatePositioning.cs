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
            owner.move.MoveReset();//���Z�b�g����
        }

        public override void OnUpdate(Player owner)
        {
            if(!owner.move.MoveControl())//�����Ȃ��Ȃ�����ʒu���߂̌�ɑJ��(�����łȂ��ꍇ�͎��R�ɓ�������)
            {
                owner.ChangeState(stateAfterPositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
           
        }
    }
}
