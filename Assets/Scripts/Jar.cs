using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jar : MonoBehaviour
{
    bool wasInitiated = false;
    void OnMouseDown()
    {
        if(!wasInitiated && !FindObjectOfType<TextBox>().isWritingDialogue && !FindObjectOfType<TodoList>().spiritAcquired)
        {
            wasInitiated = true;
            FindObjectOfType<TextBox>().SetResponses(gameObject, "Take the British one", "Right", "Take the Native American one", "Wrong", "Take the one with both British and Native participants", "Wrong");
            FindObjectOfType<TextBox>().Dialogue("you walk towards the massive jar of sampling spirits, trying to pick the right one");
        }
    }

    void Wrong()
    {
        FindObjectOfType<TextBox>().Dialogue("you realize this is not the right spirit");
    }

    void Right()
    {
        FindObjectOfType<TextBox>().Dialogue("you take the spirit. The professor starts to look more impatient");
        FindObjectOfType<TextBox>().SetResponses(gameObject, "I have to hurry", "AcquireSpirit");
    }

    void AcquireSpirit()
    {
        FindObjectOfType<TextBox>().DisableDialogueBox();
        FindObjectOfType<TodoList>().MarkOffSpirit();
        Destroy(FindObjectOfType<GhostMovement>().gameObject);
    }
}
