using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void EnableDialogueBox()
    {
        if(!GetComponent<TextMeshProUGUI>().isActiveAndEnabled)
        {
            GetComponent<TextMeshProUGUI>().enabled = true;
            textMesh = GetComponent<TextMeshProUGUI>();
        }
        if(!GetComponentInParent<Image>().isActiveAndEnabled)
            GetComponentInParent<Image>().enabled = true;
    }

   public void DisableDialogueBox()
    {
        if(GetComponent<TextMeshProUGUI>().isActiveAndEnabled)
            GetComponent<TextMeshProUGUI>().enabled = false;
        if(GetComponentInParent<Image>().isActiveAndEnabled)
            GetComponentInParent<Image>().enabled = false;
    }

    public float speed = 10;
    public bool isDialogueSkipped = false;
    
    public void DialogueWithTitle(string title, string text)
    {
        EnableDialogueBox();
        StartCoroutine(DialogueWithTitleProcessor(title, text));
    }
    IEnumerator DialogueWithTitleProcessor(string title, string text)
    {
        isDialogueSkipped = false;
        //todo: add a skip dialogue when another dialogue starts
        string titleText = "<color=\"yellow\">" + title + ": ";
        string bodyText = "<color=\"white\">";
        foreach(char t in text)
        {
        bodyText += t;
        textMesh.SetText(titleText + bodyText);
        if(!isDialogueSkipped)
            yield return new WaitForSecondsRealtime(1.0f/speed);
        else
            yield return new WaitForSecondsRealtime(0);
        }
    }
    
    public void Dialogue(string text)
    {
        EnableDialogueBox();
        StartCoroutine(DialogueProcessor(text));
    }
    IEnumerator DialogueProcessor(string text)
    {
        isDialogueSkipped = false;
        //todo: add a skip dialogue when another dialogue starts
        string sentText = "";
        foreach(char t in text)
        {
        sentText += t;
        textMesh.SetText(sentText);
        if(!isDialogueSkipped)
            yield return new WaitForSecondsRealtime(1.0f/speed);
        else
            yield return new WaitForSecondsRealtime(0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
            isDialogueSkipped = true;
    }
}
