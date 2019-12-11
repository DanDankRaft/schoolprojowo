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

    void Response1()
    {
        Debug.Log("response 1");
    }
    void Response2()
    {
        Debug.Log("response 2");
    }
    void Response3()
    {
        Debug.Log("response 3");
    }

    void OnMouseDown()
    {
        if(time==0)
        {
            TextBox leBox = FindObjectOfType<TextBox>();
            FindObjectOfType<TextBox>().DialogueWithTitle("Bartlet", "you are a fool and an idiot!");
            leBox.SetResponses(gameObject, "Response ONE", "Response1", "Response TWO", "Response2", "Response THREE", "Response3");
            leBox.EnableChoices(3);
        }
        else
            FindObjectOfType<TextBox>().DialogueWithTitle("Bartlet", "why have thou pressed me a second time???");
        time++;
    }
}
