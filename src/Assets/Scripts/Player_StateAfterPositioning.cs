using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    //�ʒu���߂̌�
    public class StateAfterPositioning : PlayerStateBase
    {
        public override void OnEnter(Player owner, PlayerStateBase prevState)
        {
            owner.putFoot.Put();//����u��
        }

        public override void OnUpdate(Player owner)
        {

        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {

        }
    }
}
