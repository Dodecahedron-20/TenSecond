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

    //other UI
    [SerializeField]
    private Text WiresText = null;
    [SerializeField]
    private int WiresTotal;
    //[SerializeField]
    private int Wiresleft;
    
    [SerializeField]
    private Text FinalWireCountText;


    // here go boom
    [SerializeField]
    private GameObject explosion = null;
    [SerializeField]
    private GameObject explosionTwo = null;
    [SerializeField]
    private GameObject explosionThree = null;
    [SerializeField]
    private AudioSource boomAudio = null;
    [SerializeField]
    private AudioSource boomAudio2 = null;
    [SerializeField]
    private AudioSource boomAudio3 = null;

    //game End Assets
    [SerializeField]
    private GameObject EndGameScreen = null;
    [SerializeField]
    private Text FinalNumberText = null;
    [SerializeField]
    private Text OutcomeText = null;
    [SerializeField]
    private GameObject ScreenUI = null;

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

        //the wire coutdown
        Wiresleft = WiresTotal;
        WiresText.text = "Wires:" + Wiresleft;




    }

    // Update is called once per frame
    void Update()
    {
       

        
        
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
                StartCoroutine(KaBoom());
                Bomb.SetActive(false);
                ScreenUI.SetActive(false);
                win = false;

                yield return new WaitForSeconds(2);

                EndGame();
            }

        }
        

    }


    IEnumerator KaBoom()
    {
        explosion.SetActive(true);
        boomAudio.Play();

        yield return new WaitForSeconds(0.5f);

        explosionTwo.SetActive(true);
        boomAudio2.Play();

        yield return new WaitForSeconds(0.3f);

        explosionThree.SetActive(true);
        boomAudio3.Play();
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


    public void wiresLeftUI()
    {
        Wiresleft--;
        WiresText.text = "Wires: " + Wiresleft;
        CheckWires();
    }


    private void CheckWires()
    {
        if (Wiresleft == 0)
        {
            win = true;
            StartCoroutine(WinPause());
        }
    }




  


    IEnumerator WinPause()
    {
        yield return new WaitForSeconds(0.5f);

        Bomb.SetActive(false);
        EndGame();
    }


    private void EndGame()
    {
        
        EndGameScreen.SetActive(true);
        FinalNumberText.text = "00:00:0" + secondsleft;

        var endwires = WiresTotal - Wiresleft;
        FinalWireCountText.text = "wires cut: " + endwires + "/" + WiresTotal;

        if (win == true)
        {
            OutcomeText.text = "congratulations on surviving";
            ScreenUI.SetActive(false);
        }
        else
        {
            
            OutcomeText.text = "You died";
        }

    }



}
