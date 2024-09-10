using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//動く速さ
    [SerializeField] float moveTime;//動かせる時間
    [SerializeField] Transform firstPos;//位置決めの足の初期位置
    private float currentMoveTime = 0;//現在の動かせる時間

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
        transform.position = firstPos.position;
    }

    public bool MoveControl()
    {
        //動かす時間の管理
        currentMoveTime += Time.deltaTime;

        //動かす処理
        if (currentMoveTime <= moveTime)//動かせるならtrueを返す
        {
            Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(move * speed * Time.deltaTime);
            return true;
        }
            
        //動かせなくなったらfalseを返す
        return false;
    }
}
