using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;

    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }


    public void MainMenuButton()
    {
        MainMenu.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}