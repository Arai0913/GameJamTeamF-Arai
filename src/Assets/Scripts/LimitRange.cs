using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRange : MonoBehaviour
{
    [SerializeField] float verticalUp;
    [SerializeField] float verticalDown;
    [SerializeField] float horizontalLeft;
    [SerializeField] float horizontalRight;

    
    public void Limit()//�ړ��͈͂̐���
    {
        Vector3 currentPos = transform.localPosition;
        float scaleX=transform.localScale.x;
        float scaleY = transform.localScale.y;

        currentPos.x = Mathf.Clamp(currentPos.x,horizontalLeft+scaleX,horizontalRight-scaleX);//��
        currentPos.y = Mathf.Clamp(currentPos.y, verticalDown + scaleY, verticalUp - scaleY);//�c

        transform.localPosition = currentPos;
    }
}
