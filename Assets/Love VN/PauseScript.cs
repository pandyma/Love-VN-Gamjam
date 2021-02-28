using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseScript : MonoBehaviour
{
    public UnityEvent methods;
    public static bool isPaused = false;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.gameObject.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        pauseMenu.gameObject.SetActive(true);
    }

    
}