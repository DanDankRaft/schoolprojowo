using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TextScroll : MonoBehaviour
{
    public bool isEnding;
    public float endPosition;
    public float speed=1;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(isEnding && Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        if(transform.localPosition.y < endPosition)
            transform.localPosition += Vector3.up*speed;
        else if(!isEnding && Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("BartletRoom");
    }
}
