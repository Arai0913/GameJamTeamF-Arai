using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//��������
    //[SerializeField] GameObject left;//����
    //[SerializeField] GameObject right;//�E��
    //bool moveLeftNow = true;//�������𓮂����Ă��邩�A�ŏ��ɓ������͍̂���

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void SwitchMoveFoot()//�������������ւ���
    //{
    //    moveLeftNow=!moveLeftNow;//���������𔽓]
    //}

    public void MoveControl()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //if (moveLeftNow)//�����𓮂����Ă���
        //{
        //    left.transform.Translate(move * speed * Time.deltaTime);
        //}
        //else//�E���𓮂����Ă���
        //{
        //    right.transform.Translate(move * speed * Time.deltaTime);
        //}

        transform.Translate(move * speed * Time.deltaTime);


    }
}
