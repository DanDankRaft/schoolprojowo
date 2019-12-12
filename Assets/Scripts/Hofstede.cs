using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hofstede : MonoBehaviour
{
    TextBox leBox;
    // Start is called before the first frame update
    void Start()
    {
        leBox = FindObjectOfType<TextBox>();
        leBox.EnableDialogueBox();
        leBox.SetResponses(gameObject, "Where are we?", "Conversation1");
        leBox.DialogueWithTitle("Professor Hofstede", "We have arrived.");
    }
    void Conversation1()
    {
        leBox.SetResponses(gameObject, "I thought it was just a myth.", "Conversation2");
        leBox.DialogueWithTitle("Professor Hofstede", "A dark excruciating place. A place where the summers are warm and winters freezing. A place where high schools spend ludicrous amounts of money on their football stadiums. A place where those giant horned squirrels we use as our mascot actually exist.");
    }
    void Conversation2()
    {
        leBox.SetResponses(gameObject, "Oh my god.", "Conversation3");
        leBox.DialogueWithTitle("Professor Hofstede", "Me too. And yet, here we are.");
    }
    void Conversation3()
    {
        FindObjectOfType<Webcam>().EnableWebcam();
        leBox.SetResponses(gameObject, "Oh my god.", "Conversation3");
        leBox.DialogueWithTitle("Both in unison", "Texas.");
    }

}
