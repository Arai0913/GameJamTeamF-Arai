using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed;//�X�N���[���̑���
    bool scrollNow=false;//���݃X�N���[�����Ă��邩�A��ʓ��ɑ�������Ԃ̓X�N���[������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Scroll()//�X�N���[�����Ă�Ԃ�true�A���ĂȂ��Ԃ�false��Ԃ�
    {
        if (scrollNow)
        {
            Vector2 move= Vector2.up;
            transform.Translate(move*scrollSpeed*Time.deltaTime);
            return true;//�X�N���[�����Ă���
        }

        return false;//�X�N���[�����Ă��Ȃ�
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Foot"))
        {
            scrollNow = true;
        }
        else 
        {
            scrollNow=false;
        }
    }
}
