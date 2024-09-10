using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed;//�X�N���[���̑���
    bool scrollNow=false;//���݃X�N���[�����Ă��邩�A�����J�����ɐG��Ă��鎞�̓X�N���[������

    public bool ScrollNow
    {
        get { return scrollNow; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scroll()//�X�N���[�����Ă�Ԃ�true�A���ĂȂ��Ԃ�false��Ԃ�
    {
        if (scrollNow)
        {
            Vector2 move= Vector2.up;
            transform.Translate(move*scrollSpeed*Time.deltaTime);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Foot"))
        {
            scrollNow = true;
            Debug.Log("�G��Ă܂�");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Foot"))
        {
            scrollNow = false;
            Debug.Log("�G��Ă܂���");
        }
    }
}
