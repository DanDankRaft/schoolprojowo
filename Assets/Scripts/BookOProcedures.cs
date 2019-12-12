using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookOProcedures : MonoBehaviour
{
    bool wasInitiated = false;
    void OnMouseDown()
    {
        Debug.Log("initiated!");
        if(!wasInitiated && !FindObjectOfType<TextBox>().isWritingDialogue && !FindObjectOfType<TodoList>().bookAcquired)
        {
            wasInitiated = true;
            FindObjectOfType<TextBox>().SetResponses(gameObject, "what even is that", "Explanation");
            FindObjectOfType<TextBox>().Dialogue("The professor yells something about <i>The War of The Ghosts</i> page");
        }
    }

    void Explanation()
    {
        FindObjectOfType<TextBox>().SetResponses(gameObject, "what's an American", "Explanation2");
        FindObjectOfType<TextBox>().DialogueWithTitle("Professor Bartlett" , "It's in the true experiments section. We tell the participants this native american legend in a native american way. Afterwards, they are put in either a repeated reproduction group or serial reproduction group");
    }

    void Explanation2()
    {
        FindObjectOfType<TextBox>().SetResponses(gameObject, "Texas isn't real", "Explanation3");
        FindObjectOfType<TextBox>().DialogueWithTitle("Professor Bartlett" , "No clue. I think they have them in Texas. Anyhow, the first group was told to reproduce the story repeatedly over a long period of time. The serial group had to tell it to another person.");
    }

    void Explanation3()
    {
        FindObjectOfType<TextBox>().SetResponses(gameObject, "[you tear the page]", "AcquireBook");
        FindObjectOfType<TextBox>().DialogueWithTitle("Professor Bartlett" , "yeah, whatever. Just tear the page up already! My potion's about to start burning, I need to mix it in NOW!!!!");
    }

    void AcquireBook()
    {
        FindObjectOfType<TextBox>().DisableDialogueBox();
        FindObjectOfType<TodoList>().MarkOffBook();
        Destroy(gameObject);
    }
}
