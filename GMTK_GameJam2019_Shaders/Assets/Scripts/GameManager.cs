﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string Level01;
    public string MainMenu;

    bool isInMenu;
    
    [SerializeField] public GameObject pausePanel;
    [SerializeField] public GameObject uiPanel;
    [SerializeField] public GameObject settingPanel;
    [SerializeField] public GameObject creditsPanel;
    [SerializeField] public GameObject quitPanel;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&!isInMenu)
        {
            isInMenu = true;
            PauseGame();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isInMenu)
        {
            UnPauseGame();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(Level01);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        uiPanel.SetActive(false);
        pausePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }


    public void UnPauseGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        settingPanel.SetActive(false);
        creditsPanel.SetActive(false);
        quitPanel.SetActive(false);
        uiPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        isInMenu = false;
    }

    public void ShowImpulseIcon()
    {
        uiPanel.SetActive(true);
    }

    public void CloseImpulseIcon()
    {
        uiPanel.SetActive(false);
    }
}
