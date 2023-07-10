using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuLogic : MonoBehaviour
{
    private GameObject mainMenu;
    private GameObject loading;

    public AudioSource buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu = GameObject.Find("MainMenuCanvas");
        loading = GameObject.Find("LoadingCanvas");

        mainMenu.GetComponent<Canvas>().enabled = true;
        loading.GetComponent<Canvas>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        loading.GetComponent<Canvas>().enabled = true;
        mainMenu.GetComponent<Canvas>().enabled = false;
        buttonSound.Play();
        SceneManager.LoadScene("IntroNarasi");
    }

    public void QuitButton()
    {
        buttonSound.Play();
        Application.Quit();
    }
}
