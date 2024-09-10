using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase : MonoBehaviour
{
    public virtual void OnEnter(){ }//���̏�Ԃ̍ŏ��ɂ�鏈��
    public virtual void OnUpdate() { }//���̏�ԂŖ��t���[����鏈��
    public virtual void OnExit() { }//���̏�Ԃ̍Ō�ɂ�鏈��
}
