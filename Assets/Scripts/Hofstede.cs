using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
        leBox.SetResponses(gameObject, "Are those the monsters you talked about?", "Conversation4");
        leBox.DialogueWithTitle("Both in unison", "Texas.");
    }
    void Conversation4()
    {
        leBox.SetResponses(gameObject, "I'll do it then. Hang on tight!", "Conversation5");
        leBox.DialogueWithTitle("Professor Hofstede", "Yes. And the only way to defeat them is to answer their questions about whatever study I did yesterday, but unfortunately Professor Squire removed my hippocampus.");
    }
    void Conversation5()
    {
        leBox.SetResponses(gameObject, "To study the effects of globalization", "JosianneWrong", "To identify serializable ways in which we could differentiate the psychological patterns of cultures", "Conversation6", "To find the PDI of different countries?", "JosianneWrong");
        leBox.DialogueWithTitle("Josianne", "What was the aim of Hofstede et al 1973?");
    }
    void JosianneWrong()
    {
        leBox.DialogueWithTitle("Josianne", "Wrong!");
    }
    void Conversation6()
    {
        leBox.SetResponses(gameObject, "120 Harvard students", "TiffanyWrong", "8,000 first generation migrants to the United States", "TiffanyWrong", "Over 100,000 IBM employees from different countries", "Conversation7");
        leBox.DialogueWithTitle("Tiffany", "What was his sample?");
    }
    void TiffanyWrong()
    {
        leBox.DialogueWithTitle("Tiffany", "Wrong!");
    }
     void Conversation7()
    {
        leBox.SetResponses(gameObject, "True experiment", "NoorWrong", "Survey", "Conversation8", "Natural Experiment", "NoorWrong");
        leBox.DialogueWithTitle("Noor", "What was his design?");
    }
    void NoorWrong()
    {
        leBox.DialogueWithTitle("Noor", "Wrong!");
    }
     void Conversation8()
    {
        leBox.SetResponses(gameObject, "uhhhh...", "Conversation9");
        leBox.DialogueWithTitle("Sebastian", "I'm not even in this class!");
    }
    void Conversation9()
    {
        leBox.SetResponses(gameObject, "oh no...", "Conversation10");
        leBox.DialogueWithTitle("Ms. Gaskill", "Finally. It is my turn. If you get my question wrong you will have to do google doc reviews for the rest of your life!!!!!");
    }
    void Conversation10()
    {
        leBox.SetResponses(gameObject, "[proceed to explain it]", "Conversation11");
        leBox.DialogueWithTitle("Ms. Gaskill", "Define individualism vs collectivism");
    }
    void Conversation11()
    {
        leBox.SetResponses(gameObject, "...", "Conversation12");
        leBox.DialogueWithTitle("Player", "In individualist societies, the ties between individuals are loose: everyone is expected to look after himself or herself and his or her immediate family. In collectivist societies, from birth onwards people are integrated into strong, cohesive in-groups, often extended families (with uncles, aunts, and grandparents), which provides them with support and protection (Aranés & Aldabó, 2019).");
    }
    void Conversation12()
    {
        leBox.SetResponses(gameObject, "...", "EndOfLevel");
        leBox.DialogueWithTitle("Ms. Gaskill", "Oh. You're <i>good.</i> Fine, I will give you the helmet. But even with it, there is no chance you will survive what's coming next...");
    }
    public GameObject EndOfLevelThing;
    void EndOfLevel()
    {
        leBox.DisableDialogueBox();
        EndOfLevelThing.SetActive(true);
    }

    public void FinalBoss1()
    {
        Destroy(EndOfLevelThing);
        leBox.SetResponses(gameObject, "oh no.", "FinalBoss2");
        leBox.DialogueWithTitle("Professor Hofstede", "I sense a being of great power approaching...");
    }
    void FinalBoss2()
    {
        leBox.SetResponses(gameObject, "I must face my destiny", "FinalBoss3");
        leBox.DialogueWithTitle("Semesterus Examus", "Grrrrrr.....");
    }
    public GameObject SemesterusExamus;
    void FinalBoss3()
    {
        leBox.SetResponses(gameObject, "I have to destory it...", "FinalBoss4");
        leBox.DialogueWithTitle("Semesterus Examus", "Meow");
    }
    void FinalBoss4()
    {
        SemesterusExamus.GetComponent<SpriteRenderer>().enabled = true;
        leBox.SetResponses(gameObject, "using my knowledge of classification systems in Abnormal psychology", "FinalBoss5");
        leBox.DialogueWithTitle("Semesterus Examus", "<i>[licks its own feet]</i>");
    }
    void FinalBoss5()
    {
        leBox.SetResponses(gameObject, "[read off of my abnormal google doc because i'm tired]", "FinalBoss6");
        leBox.DialogueWithTitle("Semesterus Examus", "<i>[playing with a yarn ball]</i>");
    }
    void FinalBoss6()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss7");
        leBox.DialogueWithTitle("Player", "Classification guides are used to provide information and assistance in diagnosing disorders. They also aim to make diagnosis as standard as possible.");
    }
    void FinalBoss7()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss8");
        leBox.DialogueWithTitle("Player", "DSM V- guide commonly used in the United States. It is mainly based on clinical and mental conditions, psychological stressors and interference with one’s daily life. It is specifically designed by American psychiatrists for American patients. As such, it is relatively unaffordable compared to other guides.");
    }
    void FinalBoss8()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss9");
        leBox.DialogueWithTitle("Player", "ICD (International Classification of Diseases)- a guide developed by the WHO. It is meant to be universal and affordable. It is multilingual and multidisiplinary in nature.");
    }
    void FinalBoss9()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss10");
        leBox.DialogueWithTitle("Player", "CCMD- a guide used in China. Unlike the other two, it defines disorders in a way that is more culturally appropriate for Han Chinese culture.");
    }
    void FinalBoss10()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss11");
        leBox.DialogueWithTitle("Player", "Temerlin (1970) aimed to reveal confirmation bias in diagnosis");
    }
    void FinalBoss11()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss12");
        leBox.DialogueWithTitle("Player", "Design and Sample: Clinical psychologists (78 in control group), true experiment.");
    }
    void FinalBoss12()
    {
        leBox.SetResponses(gameObject, "...", "FinalBoss13");
        leBox.DialogueWithTitle("Player", "Procedure: All participants watched a clinical interview of an individual. The experimental group also heard a respected psychiatrist say he’s psychotic. The control group did not hear any commentary. Afterwards, the participants were given 30 different choices for diagnosis, including 10 neurotics, 10 psychotics, and 10 other choices.");
    }
    void FinalBoss13()
    {
        leBox.SetResponses(gameObject, "That's all I have!!", "FinalBoss14");
        leBox.DialogueWithTitle("Player", "Results: 60% of participants in the experimental group said he was psychotic. 0% of the control said the same.");
    }
    void FinalBoss14()
    {
        leBox.SetResponses(gameObject, "I defeated Semesterus Examus.", "FinalBoss15");
        leBox.DialogueWithTitle("Semesterus Examus", "Meow.");
    }
    void FinalBoss15()
    {
        SemesterusExamus.GetComponent<SpriteRenderer>().enabled = false;
        leBox.SetResponses(gameObject, "It's over.", "FinalBoss16");
        leBox.Dialogue("");
    }
    void FinalBoss16()
    {
        SceneManager.LoadScene("YouWon");
    }


}
