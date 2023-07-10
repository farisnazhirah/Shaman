using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    public GameObject menu;
    public GameObject resume;
    public GameObject exit;

    public bool on;
    public bool off;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        off = true;
        on = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (off && Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            off = false;
            on = true;
            UnlockMouse();
        } 
        
        else if (on && Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 1;
            menu.SetActive(false);
            off = true;
            on = false;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        off = true;
        on = false;
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
