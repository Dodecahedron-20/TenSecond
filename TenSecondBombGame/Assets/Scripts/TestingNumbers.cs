using System.Collections;
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
    private AudioSource boomAudio = null;


    //game End Assets
    [SerializeField]
    private GameObject EndGameScreen = null;
    [SerializeField]
    private Text FinalNumberText = null;
    [SerializeField]
    private Text OutcomeText = null;

    private bool win = false;

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
            wingame();
        }
    }


   
    IEnumerator Countdown()
    {
        

        if (win != true)
        {

            yield return new WaitForSeconds(1);

            SecondGone();

            if (secondsleft > 0)
            {
                StartCoroutine(Countdown());
            }
            else
            {
                explosion.SetActive(true);
                boomAudio.Play();
                Bomb.SetActive(false);
                win = false;

                yield return new WaitForSeconds(1);

                EndGame();
            }

        }
        

    }



    private void SecondGone()
    {
       if (win == false)
        {
            secondsleft--;
            secondsText.text = "" + secondsleft;
            UISecondsleftText.text = "00:00:0" + secondsleft;
            if (secondsleft != 0)
            {
                tickAudio.Play();
            }
        }
        
        








        // else
        //{
        //explosion.SetActive(true);
        // }

    }

    //testing the win screen
   private void wingame()
    {
        Bomb.SetActive(false);
        win = true;
        EndGame();

    }



    private void EndGame()
    {
        
        EndGameScreen.SetActive(true);
        FinalNumberText.text = "00:00:0" + secondsleft;

        if (win == true)
        {
            OutcomeText.text = "congratulations on surviving";
        }
        else
        {
            OutcomeText.text = "You died";
        }

    }



}
