using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFoot : MonoBehaviour
{
    bool moveLeftNow = true;//今左足を動かしているか
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchFoot()//動かす足を反転
    {
        moveLeftNow=!moveLeftNow;
    }

    public bool CurrentMovingFoot()//今動かしている足を返す(左足ならtrue)
    {
        return moveLeftNow;
    }
}
