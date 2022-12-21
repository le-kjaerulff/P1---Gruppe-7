using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tutorial : MonoBehaviour
{

    QuestionsAudioPlayer questionsAudioPlayer;
    Animator cowAnimator;
    Animator pigAnimator;
    Animator sheepAnimator;



    void Start()
    {
        questionsAudioPlayer = this.GetComponent<QuestionsAudioPlayer>();
        cowAnimator = GameObject.Find("cow sprite sheet_0").GetComponent<Animator>();
        pigAnimator = GameObject.Find("pig sprite sheet_0").GetComponent<Animator>();
        sheepAnimator = GameObject.Find("sheep sprite sheet_0").GetComponent<Animator>();
    }

    void Update()
    {
        UserControls();

    }


    void UserControls()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cowAnimator.SetTrigger("CowWasPicked");
            questionsAudioPlayer.audioPlayer.PlayOneShot(questionsAudioPlayer.animalSounds[0]);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            pigAnimator.SetTrigger("PigWasPicked");
            questionsAudioPlayer.audioPlayer.PlayOneShot(questionsAudioPlayer.animalSounds[1]);
        }
        if ( Input.GetKeyDown(KeyCode.RightArrow))
        {
            sheepAnimator.SetTrigger("SheepWasPicked");
            questionsAudioPlayer.audioPlayer.PlayOneShot(questionsAudioPlayer.animalSounds[2]);
        }
    }
    

}


