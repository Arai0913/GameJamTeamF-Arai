using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//��������
    [SerializeField] float moveTime;//�������鎞��
    [SerializeField] Transform firstPos;//�ʒu���߂̑��̏����ʒu
    private float currentMoveTime = 0;//���݂̓������鎞��

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveReset()
    {
        currentMoveTime = 0;
        transform.position = firstPos.position;
    }

    public bool MoveControl()
    {
        //���������Ԃ̊Ǘ�
        currentMoveTime += Time.deltaTime;

        //����������
        if (currentMoveTime <= moveTime)//��������Ȃ�true��Ԃ�
        {
            Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(move * speed * Time.deltaTime);
            return true;
        }
            
        //�������Ȃ��Ȃ�����false��Ԃ�
        return false;
    }
}
