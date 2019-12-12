using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndLevelScreen : MonoBehaviour
{
    public int mode = 0;

    void Update()
    {
        if(mode == 0)
        {
            if(Input.GetKey(KeyCode.Space))
                SceneManager.LoadScene("Lecture Hall");
        }

        if(mode == 1)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                FindObjectOfType<HofstedeIntro>().Intro1();
            }
        }
        if(mode == 2)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                FindObjectOfType<Hofstede>().FinalBoss1();
            }
        }
    }
}
