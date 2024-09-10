using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTime : MonoBehaviour
{
    [SerializeField] float moveTime;//�������鎞��
    private float currentMoveTime = 0;//���݂̓������鎞��

    void Update()
    {
        currentMoveTime += Time.deltaTime;
    }

    public void ResetMoveTime()//���݂̓������鎞�Ԃ����Z�b�g
    {
        currentMoveTime = 0;
    }

    public bool CanMove()//��������Ȃ�true���A�������Ȃ��Ȃ�����false��Ԃ�
    {
        if (currentMoveTime <= moveTime) return true;//�܂���������

        return false;//�������Ȃ�
    }
}
