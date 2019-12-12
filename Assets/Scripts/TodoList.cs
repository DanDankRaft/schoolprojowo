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
            transform.Find(name).GetComponent<TextMeshProUGUI>().text = "";
        appleAcquired = true;
        if(appleAcquired && bookAcquired && spiritAcquired)
            FinalConversation();
    }

    public void MarkOffBook()
    {
        string name = "Book Text";
        if(!appleAcquired)
            transform.Find(name).GetComponent<TextMeshProUGUI>().text = "";
        bookAcquired = true;
        if(appleAcquired && bookAcquired && spiritAcquired)
            FinalConversation();
    }

    public void MarkOffSpirit()
    {
        string name = "Sampling Spirit Text";
        if(!appleAcquired)
            transform.Find(name).GetComponent<TextMeshProUGUI>().text = "";
        spiritAcquired = true;
        if(appleAcquired && bookAcquired && spiritAcquired)
            FinalConversation();
    }

    void FinalConversation()
    {
        Debug.Log("All Finished!!");
        FindObjectOfType<Bartlet>().FinalConversation();
        gameObject.SetActive(false);

    }

}
