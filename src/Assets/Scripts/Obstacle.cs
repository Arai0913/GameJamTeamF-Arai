using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ObstacleFoot"))
        {
            //�C����Q���ɐG�ꂽ��Q�[���I�[�o�[
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
