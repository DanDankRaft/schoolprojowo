using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HofstedeIntro : MonoBehaviour
{
    TextBox leBox;
    public void Intro1()
    {
        FindObjectOfType<EndLevelScreen>().gameObject.SetActive(false);
        leBox = FindObjectOfType<TextBox>();
        leBox.EnableDialogueBox();
        leBox.SetResponses(gameObject, "Who is it?", "Intro2");
        leBox.DialogueWithTitle("<i>OMNIOUS VOICE</i>", "HALT! PLAYER, I NEED YOUR HELP");
    }

    public void Intro2()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Animator>().Play("HofstedeFlashing");
        leBox.SetResponses(gameObject, "...", "Intro3");
        leBox.DialogueWithTitle("<i>OMNIOUS VOICE</i>", "IT IS I");

    }
    public void Intro3()
    {
        GetComponent<Animator>().Play("Default");
        leBox.SetResponses(gameObject, "Professor Hofstede!", "Intro4");
        leBox.Dialogue("");

    }
    public void Intro4()
    {
        leBox.SetResponses(gameObject, "Oh no!", "Intro5");
        leBox.DialogueWithTitle("Professor Hofstede", "YES. IT IS I. PROFESSOR GREET HOFSTEDE. AND I URGENTLY NEED YOUR HELP. EVIL MONSTERS FROM A MAGICAL REALM ARE PLANNING ON ATTACKING US.");
    }
    public void Intro5()
    {
        leBox.SetResponses(gameObject, "Then we must leave right now.", "Intro6");
        leBox.DialogueWithTitle("Professor Hofstede", "OH NO INDEED. I WILL NEED YOUR HELP TO DEFEAT THEM. WE HAVE TO LEAVE AT HASTE");
    }
    public void Intro6()
    {
        leBox.SetResponses(gameObject, "Seriously?", "Intro7");
        leBox.DialogueWithTitle("Professor Squire", "Hey Greet do you have any scalpel or knife or some kind of sharp object I could use?");
    }
    public GameObject player;
    public void Intro7()
    {
        GetComponent<Animator>().Play("HofstedeFlashing");
        player.GetComponent<Animator>().Play("PlayerFlashing");
        leBox.SetResponses(gameObject, "<i>[The two of you leave for the magical realm]", "Intro8");
        leBox.DialogueWithTitle("Professor Hofstede", "NO.");
    }
    public void Intro8()
    {
        SceneManager.LoadScene("Texas");
    }
}
