using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����u��
//��->�E�̌��݂ɒu���悤�ɂ���
public class PutFoot : MonoBehaviour
{
    [SerializeField] GameObject LeftFoot;
    [SerializeField] GameObject RightFoot;
    [SerializeField] GameObject FootPosition;
    [SerializeField] CurrentFoot currentFoot;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //����u��(���A�E������)
    public void Put()
    {
        if (currentFoot.CurrentMovingFoot())//������u��
        {
            LeftFoot.transform.position = FootPosition.transform.position;
        }
        else//�E����u��
        {
            RightFoot.transform.position = FootPosition.transform.position;
        }
    }
}
