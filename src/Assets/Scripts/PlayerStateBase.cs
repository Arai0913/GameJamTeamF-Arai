using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase
{
    public virtual void OnEnter(Player owner, PlayerStateBase prevState) { }//���̏�Ԃ̍ŏ��ɂ�鏈��
    public virtual void OnUpdate(Player owner) { }//���̏�ԂŖ��t���[����鏈��
    public virtual void OnExit(Player owner, PlayerStateBase nextState) { }//���̏�Ԃ̍Ō�ɂ�鏈��
}
