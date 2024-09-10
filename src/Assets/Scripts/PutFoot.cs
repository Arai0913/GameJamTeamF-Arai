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

    bool Left = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�u������؂�ւ���
    public void SwitchFoot()
    {
        if (Left)
        {
            Left = false; //�E���ɐ؂�ւ���
        }
        else
        {
            Left = true; //�����ɐ؂�ւ���
        }
    }

    //����u��(���A�E������)
    public void Put()
    {
        if (Left)
        {
            LeftFoot.transform.position = FootPosition.transform.position;
        }
        else
        {
            RightFoot.transform.position = FootPosition.transform.position;
        }

        SwitchFoot();
    }
}
