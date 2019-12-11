using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChoice : MonoBehaviour
{
    public GameObject target;
    public string eventFunction;

    public void OnClicked()
    {
        target.SendMessage(eventFunction);
        FindObjectOfType<TextBox>().DisableChoices(3);
    }
}
