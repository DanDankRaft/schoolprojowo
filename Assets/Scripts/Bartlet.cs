using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bartlet : MonoBehaviour
{
    TextBox leBox;
    // Start is called before the first frame update
    void Start()
    {
        leBox = FindObjectOfType<TextBox>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool wasInitiated = false;
    void OnMouseDown()
    {
        if(!wasInitiated)
        {
        leBox.EnableDialogueBox();
        leBox.SetResponses(gameObject, "busy with what?", "GiveQuest");
        leBox.DialogueWithTitle("Professor Bartlet", "Hey i'm busy right now, can't talk.");
        }
        wasInitiated = true;
    }

    bool wasQuestInitiated = false;
    void GiveQuest()
    {
        leBox.SetResponses(gameObject, "okay..", "InitiateQuest");
        leBox.DialogueWithTitle("Professor Bartlet", "I'm making an experiment potion. Actually, you can help. I need an aim apple, a page from the procedure book and a sampling spirit.");
    }

    void InitiateQuest()
    {
        wasQuestInitiated = true;
        leBox.DisableDialogueBox();
    }
}
