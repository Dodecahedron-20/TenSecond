﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingNumbers : MonoBehaviour
{
    //tick tick tick, time variables:
    [SerializeField]
    private int secondsleft;
    [SerializeField]
    private Text secondsText = null;
    [SerializeField]
    private Text UISecondsleftText = null;
    [SerializeField]
    private AudioSource tickAudio = null;

    // here go boom
    [SerializeField]
    private GameObject explosion = null;
    [SerializeField]
    private GameObject Audio = null;


    //game End Assets
    [SerializeField]
    private GameObject EndGameScreen = null;
    [SerializeField]
    private Text FinalNumberText = null;
    [SerializeField]
    private Text OutcomeText = null;

    private bool lose = false;

    //Bomb thing???
    [SerializeField]
    private GameObject Bomb = null;

    // Start is called before the first frame update
    void Start()
    {
        //secondsleft = 10;
        secondsText.text = "" + secondsleft;
        UISecondsleftText.text = "00:00:" + secondsleft;
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            wintest();
        }
    }


   
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1);

        SecondGone();

        if(secondsleft > 0)
        {
            StartCoroutine(Countdown());
        }
        else
        {
            explosion.SetActive(true);
            Audio.SetActive(true);
            Bomb.SetActive(false);
            lose = true;

            yield return new WaitForSeconds(1);

            EndGame();
        }
        
    }



    private void SecondGone()
    {
        if (secondsleft > 0)
        {
            secondsleft--;
            secondsText.text = "" + secondsleft;
            UISecondsleftText.text = "00:00:0" + secondsleft;
            tickAudio.Play();
        }
       // else
        //{
            //explosion.SetActive(true);
       // }
       
    }

    //testing the win screen
   private void wintest()
    {
        Bomb.SetActive(false);
        lose = false;
        EndGame();

    }



    private void EndGame()
    {
        
        EndGameScreen.SetActive(true);
        FinalNumberText.text = "00:00:0" + secondsleft;

        if (lose == true)
        {
            OutcomeText.text = "You died";
        }
        else
        {
            OutcomeText.text = "congratulations on surviving";
        }

    }



}
