using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    [SerializeField] float fadeDuration;
    [SerializeField] float displayImageDuration;
    [SerializeField] CanvasGroup canvasGroup;

    bool StartGame = false;
    bool BackMenu = false;

    float m_Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartGame || BackMenu)
        {
            Fadeout();
        }
    }

    //�X�^�[�g�{�^���@���g���C�{�^������������
    public void PushStartButton()
    {
        if (!BackMenu)
        {
            StartGame = true;
        }
    }

    //���j���[�{�^�����������Ƃ�
    public void PushMenuButton()
    {
        if (!StartGame)
        {
            BackMenu = true;
        }
    }

    void Fadeout()
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (StartGame) //�Q�[�����n�߂�
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (BackMenu) //�X�^�[�g��ʂɖ߂�
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
