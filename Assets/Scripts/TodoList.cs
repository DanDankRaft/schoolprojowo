using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TodoList : MonoBehaviour
{
    public bool appleAcquired = false;
    public bool bookAcquired = false;
    public bool spiritAcquired = false;

    public void MarkOffApple()
    {
        string name = "Aim Apple Text";
        if(!appleAcquired)
            transform.Find(name).GetComponent<TextMeshProUGUI>().text = "<s>" + transform.Find(name).GetComponent<TextMeshProUGUI>().text + "<\\s>";
        appleAcquired = true;
    }

    public void MarkOffBook()
    {
        string name = "Book Text";
        if(!appleAcquired)
            transform.Find(name).GetComponent<TextMeshProUGUI>().text = "<s>" + transform.Find(name).GetComponent<TextMeshProUGUI>().text + "<\\s>";
        bookAcquired = true;
    }

    public void MarkOffSpirit()
    {
        string name = "Spirit Text";
        if(!appleAcquired)
            transform.Find(name).GetComponent<TextMeshProUGUI>().text = "<s>" + transform.Find(name).GetComponent<TextMeshProUGUI>().text + "<\\s>";
        spiritAcquired = true;
    }
}
