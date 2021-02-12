using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingNumbers : MonoBehaviour
{

    [SerializeField]
    private int secondsleft;
    [SerializeField]
    private Text secondsText = null;
    [SerializeField]
    private GameObject explosion = null;
    [SerializeField]
    private GameObject Particles = null;


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
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        
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
            //Particles.SetActive(true);
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
        }
       // else
        //{
            //explosion.SetActive(true);
       // }
       
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
