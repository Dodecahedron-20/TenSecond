using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{

    // in menu pages/changes:
    [SerializeField]
    private GameObject Menu = null;
    [SerializeField]
    private GameObject QuitPrompt = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Start the Game things:
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



    //Quit things:

    //when selecting the quit button bring up the Quit Yes/no option
    public void QuitPromptOn()
    {
        QuitPrompt.SetActive(true);
        Menu.SetActive(false);
    }

    //selecting No and closing the quit prompt
    public void QuitPromptOff()
    {
        QuitPrompt.SetActive(false);
        Menu.SetActive(true);
    }

    //selecting yes and quitting the game
    public void QuitGame()
    {
        Application.Quit();
    }

}
