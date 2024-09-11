using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//��������
    [SerializeField] float moveTime;//�������鎞��
    [SerializeField] float widthFirstPos;//�����ʒu����p�̕�
    [SerializeField] Transform cameraPos;//�J�����̈ʒu
    [SerializeField] Transform leftShoes;//�����̈ʒu
    [SerializeField] Transform rightShoes;//�E���̈ʒu
    [SerializeField] CurrentFoot currentFoot;//���݂̑�
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

        Vector3 currentPos = transform.position;
        float CameraY=cameraPos.position.y;

        currentPos.y = CameraY;//�C�̉A��Y���W�ʒu���J�����̒��S�_�ɂ��킹��

        float shoesX;//�C��X���W

        if(currentFoot.CurrentMovingFoot())//�����𓮂�����
        {
            shoesX = rightShoes.position.x;//�E���̌C��x���W���擾
            currentPos.x = shoesX-widthFirstPos;
        }
        else//�E���𓮂����Ƃ�
        {
            shoesX=leftShoes.position.x;
            currentPos.x=shoesX+widthFirstPos;
        }
        
        transform.position = currentPos;
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
