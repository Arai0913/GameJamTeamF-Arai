using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    //�ʒu���߂̌�
    public class StateAfterPositioning : PlayerStateBase
    {
        public override void OnEnter(Player owner, PlayerStateBase prevState)
        {
            owner.putFoot.Put();//����u��
            //���݂̑��̓����蔻�������(�������Ă���Q�[���I�[�o�[)
        }

        public override void OnUpdate(Player owner)
        {
            //��ʃX�N���[��
            //��ʃX�N���[�����I�������ʒu���߂Ɉړ�
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
            owner.putFoot.SwitchFoot();//���ݓ������Ă��鑫�����ւ���
        }
    }
}
