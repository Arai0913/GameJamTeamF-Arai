using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFoot : MonoBehaviour
{
    bool moveLeftNow = true;//�������𓮂����Ă��邩
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchFoot()//���������𔽓]
    {
        moveLeftNow=!moveLeftNow;
    }

    public bool CurrentMovingFoot()//���������Ă��鑫��Ԃ�(�����Ȃ�true)
    {
        return moveLeftNow;
    }
}
