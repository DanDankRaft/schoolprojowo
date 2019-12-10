using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bartlet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int time=0;
    void OnMouseDown()
    {
        if(time==0)
            FindObjectOfType<TextBox>().DialogueWithTitle("Bartlet", "you are a fool and an idiot!");
        else
            FindObjectOfType<TextBox>().DialogueWithTitle("Bartlet", "why have thou pressed me a second time???");
        time++;
    }
}
