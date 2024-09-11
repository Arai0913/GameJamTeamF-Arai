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
        
    }

    public void PushStartButton()
    {
        StartGame = true;
    }

    public void PushMenuButton()
    {
        BackMenu = true;
        Fadeout();
    }

    void Fadeout()
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (StartGame)
            {
                //SceneManager.LoadScene("");
            }
            else if (BackMenu)
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
