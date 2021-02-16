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
    private AudioSource boomAudio = null;


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

    //making a clip noise when clicking
    [SerializeField]
    private AudioSource ClipAudio = null;
    [SerializeField]
    private KeyCode Click;


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
        if (Input.GetKey(KeyCode.A))
        {
            wingame();
        }

        if (Input.GetKeyDown(Click))
        {
            ClipAudio.Play();
            wiresLeftUI();

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
                ScreenUI.SetActive(false);
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
            wingame();
        }
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
