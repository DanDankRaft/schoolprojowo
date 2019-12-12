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
            tBox.SetResponses(gameObject, "Are you lecturing to plants again?", "Conversation1");
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
        tBox.DialogueWithTitle("Professor Squire", "That's right! Now be careful when you remove them (Aranés & Aldabó, 2019). It is a patient's brain after all");
    }
    void Conversation8()
    {
        tBox.SetResponses(gameObject, "What kind of tasks?", "Conversation9");
        tBox.DialogueWithTitle("Professor Squire", "Excellent! After this patient wakes up, we will do a bunch of tests on him. Probably run an MRI, interview him and his family, give him an IQ test. Maybe even give him some behavioural tasks (Aranés & Aldabó, 2019)!");
    }
    void Conversation9()
    {
        tBox.SetResponses(gameObject, "<i>I'm sure his family will gladly answer all of your questions", "Conversation10");
        tBox.DialogueWithTitle("Professor Squire", "I was thinking of giving him an Autobiographical Memory Interview. I'll ask him for detailed information about his life and ask family and friends to verify if its correct (Aranés & Aldabó, 2019).");
    }
    void Conversation10()
    {
        tBox.SetResponses(gameObject, "Well what else will you make him do?", "Conversation11");
        tBox.Dialogue("The plants did not take kindly to this joke.");
    }
    void Conversation11()
    {
        tBox.SetResponses(gameObject, "What do you expect the results to be?", "Conversation12");
        tBox.DialogueWithTitle("Professor Squire", "I'm going to make him memorize pairs of objects I've glued to a piece of cardboard to see if he can memorize them (Aranés & Aldabó, 2019).");

    }
    void Conversation12()
    {
        tBox.SetResponses(gameObject, "Cool. I need my sword", "Conversation13");
        tBox.DialogueWithTitle("Professor Squire", "I mainly expect him to show damage to his short-term procedural memory. No damage to intelligence or memories from before the surgery, but I think he'll have a hard time, for instance, telling me where the bathroom is, even if he can go there on his own");

    }
    void Conversation13()
    {
        tBox.SetResponses(gameObject, "Are you?... oh my god this is going to be like with Bartlett", "Conversation14");
        tBox.DialogueWithTitle("Professor Squire", "See, on the one hand this <i>is</s> a case study, so I don't expect the results to be as generalizable. But it can still give us insight into future research and refute pre-existing models of memory such as STM (Aranés & Aldabó, 2019).");

    }
    void Conversation14()
    {
        tBox.SetResponses(gameObject, "I need the sword. I have a monster to defeat!", "Conversation15");
        tBox.DialogueWithTitle("Professor Squire", "You see, this is a whole lot like the idea of localization of function: even though every function of tghe brain does not neatly map onto a single part of it, we can generally asses what functions a specific part of the brain plays a role in.");

    }
    void Conversation15()
    {

        tBox.SetResponses(gameObject, "Close enough", "Conversation16");
        tBox.DialogueWithTitle("Professor Squire", "Ah yes! A sword! I guess you can use my scalpel. Hey class! Do any of you have a sharp object? Also, are there any volunteers for our next autopsy?");

    }
    void Conversation16()
    {
        tBox.SetResponses(gameObject, "hurray!", "Conversation17");
        tBox.Dialogue("None of the plants want to volunteer. In fact, most of them are trying to flee the lecture hall. But they can't. Because they are plants. Also who cares you got your sword!");

    }
    public GameObject EndScreen;
    void Conversation17()
    {
        tBox.DisableDialogueBox();
        EndScreen.SetActive(true);
    }
}
