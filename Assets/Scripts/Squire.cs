using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squire : MonoBehaviour
{
    TextBox tBox;
    bool wasInitiated = false;
    void OnMouseDown()
    {
        tBox = FindObjectOfType<TextBox>();
        if(!wasInitiated)
        {
            wasInitiated = true;
            tBox.EnableDialogueBox();
            tBox.SetResponses(gameObject, "are lecturing to plants again?", "Conversation1");
            tBox.DialogueWithTitle("Professor Squire", "Ah, you came just in time! We are about to start another autopsy");
        }
    }

    void Conversation1()
    {
        tBox.SetResponses(gameObject, "...", "Conversation2");
        tBox.DialogueWithTitle("Professor Squire", "Well, unlike you, these plants actually pay attention");
    }
    void Conversation2()
    {
        tBox.SetResponses(gameObject, "uhh... I have this potion for you from professor Bartlett", "Conversation3");
        tBox.Dialogue("The plants are clearly not paying any attention");
    }
    void Conversation3()
    {
        tBox.SetResponses(gameObject, "...", "Conversation4");
        tBox.DialogueWithTitle("Professor Squire", "Ah yes! I've been waiting for this potion\n<i>HE PROCEEDS TO DRINK IT</i>");
    }
    void Conversation4()
    {
        tBox.SetResponses(gameObject, "Ummm, he's a plant", "Conversation5");
        tBox.DialogueWithTitle("Professor Squire", "You know, it's really hard to find fanta suger-free fanta nowadays. Anyhow, this patient's name is Eugene Pauly. We are removing some of his limic system because of his issues with encephalitis (Andrés & Aldabó, 2019).");
    }
    void Conversation5()
    {
        tBox.SetResponses(gameObject, "alright let's do some surgery!", "Conversation6");
        tBox.Dialogue("The plants are highly offented by the implication that they don't have a brain.");
    }
    void Conversation6()
    {
        tBox.SetResponses(gameObject, "Remove the amygdala and hypothalamus!", "Wrong", "That's the Hippocampus and Hypothalamus!", "Wrong", "it would be his amydala and hippocampus.", "Conversation7");
        tBox.DialogueWithTitle("Professor Squire", "We need to remove two parts of his brain: one concerned with the transfer of short-term memory to long term memory, and another concerned with the formation of emotional memory and fear");
    }
    void Wrong()
    {
        tBox.DialogueWithTitle("Professor Squire", "nope. Try again...");
    }
    void Conversation7()
    {
        tBox.SetResponses(gameObject, "[You procceed with no caution whatsoever, for it is a plant]", "Conversation8");
        tBox.DialogueWithTitle("Professor Squire", "That's right! Now be careful when you remove them. It is a patient's brain after all");
    }
    void Conversation8()
    {
        tBox.SetResponses(gameObject, "[You procceed with no caution whatsoever, for it is a plant]", "Conversation8");
        tBox.DialogueWithTitle("Professor Squire", "That's right! Now be careful when you remove them. It is a patient's brain after all");
    }
}
