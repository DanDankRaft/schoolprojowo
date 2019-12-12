using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimApple : MonoBehaviour
{
    bool wasInitiated = false;
    void OnMouseDown()
    {
        if(!wasInitiated && !FindObjectOfType<TextBox>().isWritingDialogue && !FindObjectOfType<TodoList>().appleAcquired)
        {
            wasInitiated = true;
            FindObjectOfType<TextBox>().SetResponses(gameObject, "Interesting...", "AcquireApple");
            FindObjectOfType<TextBox>().Dialogue("you pick the apple up. as you do, you hear it whisper something about \"investigating how culture, and specifically previous knowledge embedded because of culture, influences knowledge\"");
        }
    }

    void AcquireApple()
    {
        FindObjectOfType<TextBox>().DisableDialogueBox();
        FindObjectOfType<TodoList>().MarkOffApple();
        Destroy(gameObject);
    }
}
