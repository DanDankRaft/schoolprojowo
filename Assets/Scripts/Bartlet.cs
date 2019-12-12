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
    bool wasInitiated = false;
    void OnMouseDown()
    {
        if(!wasInitiated)
        {
        leBox.EnableDialogueBox();
        leBox.SetResponses(gameObject, "busy with what?", "GiveQuest");
        leBox.DialogueWithTitle("Professor Bartlett", "Hey i'm busy right now, can't talk.");
        }
        wasInitiated = true;
    }

    bool wasQuestInitiated = false;
    void GiveQuest()
    {
        leBox.SetResponses(gameObject, "okay..", "InitiateQuest");
        leBox.DialogueWithTitle("Professor Bartlett", "I'm making an experiment potion. Actually, you can help. I need an aim apple, a page from the procedure book and a sampling spirit.");
    }

    public GameObject ItemsListGUI;
    void InitiateQuest()
    {
        
        wasQuestInitiated = true;
        leBox.DisableDialogueBox();
        ItemsListGUI.SetActive(true);
        //make apple, book, ghost jar clickable
            //add items to scene
            //make them clickable
            //make script for them
    }

    public void FinalConversation()
    {
        Debug.Log("We reached Bartlett");
        leBox.SetResponses(gameObject,"...", "FinalConversation2");
        leBox.DialogueWithTitle("Professor Bartlett", "finally! It should be ready any mome-");
        leBox.EnableDialogueBox();
    }
    public void FinalConversation2()
    {
        leBox.SetResponses(gameObject,"...", "FinalConversation3");
        leBox.Dialogue("you hear a small explosion. You also start smelling burnt paper");
    }

    public void FinalConversation3()
    {
        leBox.SetResponses(gameObject,"What was the point of all of this", "FinalConversation4");
        leBox.DialogueWithTitle("Professor Bartlett","Yes! It worked!! My potion is finished!!");
    }

    public void FinalConversation4()
    {
        leBox.SetResponses(gameObject,"How so?", "FinalConversation5");
        leBox.DialogueWithTitle("Professor Bartlett","I wanted to see what would happen! <i>it's an experiment</i>. As it seems, both groups <b>distorted</b> the story as they recalled it, changing details about it (Aranés & Aldabó, 2019).");
    }
    public void FinalConversation5()
    {
        leBox.SetResponses(gameObject,"Cool. can I have my sheid now?", "FinalConversation6");
        leBox.DialogueWithTitle("Professor Bartlett","They made the details more... British. It also became shorter and more consistent with the way British people tend to tell stories (Aranés & Aldabó, 2019).");
    }
    public void FinalConversation6()
    {
        leBox.SetResponses(gameObject,"Sir, I need my shield", "FinalConversation7");
        leBox.DialogueWithTitle("Professor Bartlett","Although I have my doubts. The lack of a control and the quasi-experimental nature of this potion means I cannot establish a direct causational relationship between culture and schema, only a correlational one (Aranés & Aldabó, 2019).");
    }
    public void FinalConversation7()
    {
        leBox.SetResponses(gameObject,"I NEED MY SHIELD", "FinalConversation8");
        leBox.DialogueWithTitle("Professor Bartlett","Overall though, it does seem to confirm my theory on schemas, or the concept that mental represantations of the real world through memories are built on prior knowledge and real-world experience (Aranés & Aldabó, 2019).");
    }
    public void FinalConversation8()
    {
        leBox.SetResponses(gameObject,"sure I'll do it", "EndLevel");
        leBox.DialogueWithTitle("Professor Bartlett","Oh yeah, that thing. There you go. By the way, when you go see Professor Squire, can you give him the potion?");
    }

    public GameObject endOfLevelBox;
    public void EndLevel()
    {
        endOfLevelBox.SetActive(true);
    }
}
