using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove : MonoBehaviour
{
    [SerializeField] Transform startPos;//�X�^�[�g�n�_
    [SerializeField] float backToStartTime=0;//�X�^�[�g�n�_�ɖ߂�܂ł̎���
    [SerializeField] float speed;//����
    float currentTime=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed*Time.deltaTime);
        currentTime += Time.deltaTime;

        if(currentTime>backToStartTime)
        {
            ResetPos();
        }
    }

    void ResetPos()
    {
        transform.position = startPos.position;
        currentTime = 0;
    }
}
