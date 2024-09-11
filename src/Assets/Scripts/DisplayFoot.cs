using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFoot : MonoBehaviour
{
    [SerializeField] GameObject left;
    [SerializeField] GameObject right;
    [SerializeField] CurrentFoot currentFoot;

    private void Update()
    {
        
    }

    public void Display()
    {
        if (currentFoot.CurrentMovingFoot())//����
        {
            left.SetActive(true);
            right.SetActive(false);
        }
        else//�E��
        {
            left.SetActive(false);
            right.SetActive(true);
        }
    }
}
