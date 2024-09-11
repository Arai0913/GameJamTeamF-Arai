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
            owner.cameraScroll.ScrollTrigger();//true�ɂ���
        }

        public override void OnUpdate(Player owner)
        {
            //��ʃX�N���[��
            owner.cameraScroll.Scroll();

            if (!owner.cameraScroll.ScrollNow)//�X�N���[�����Ȃ��Ȃ�����ʒu���߂ɑJ��
            {
                owner.ChangeState(statePositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
            owner.currentFoot.SwitchFoot();//���ݓ������Ă��鑫�����ւ���
            owner.displayFoot.Display();
        }
    }
}
