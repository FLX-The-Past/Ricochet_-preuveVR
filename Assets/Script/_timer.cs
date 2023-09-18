using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class _timer : MonoBehaviour
{
    public bool timerActive = false;
    public float CurrentTime;
    public float HightTime;
    public TMP_Text HightTimeText;
    public TMP_Text CurrentTimeText;
    public AudioSource buttonPressed;
    public GameObject stopButton;
    public GameObject restartButton;
    public GameObject quitButton;
    public GameObject _timertext;
    public GameObject backButton;
    public GameObject _menu;
    public GameObject rulesMenu;
    void Start()
    {
        stopButton.SetActive(false);
        restartButton.SetActive(false);
        quitButton.SetActive(true);
        _timertext.SetActive(false);
        backButton.SetActive(false);
        _menu.SetActive(true);
        
        CurrentTime = 0;
    }

    
    void Update()
    {
        if (timerActive == true)
        {
            CurrentTime = CurrentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
        CurrentTimeText.text = time.ToString(@"mm\:ss\:fff");

        if (timerActive == false)
        {
            CurrentTime = CurrentTime;
        }
    }

    public void StarTimer()
    {
        buttonPressed.Play();
        timerActive = true;
        _menu.SetActive(false);
        stopButton.SetActive(true);
        restartButton.SetActive(false);
        _timertext.SetActive(true);
    }

    public void StopTimer()
    {
        buttonPressed.Play();
        timerActive = false;
        stopButton.SetActive(false);
        restartButton.SetActive(true);
        quitButton.SetActive(false);
    }

    public void ResetTimer()
    {
        if (timerActive == false)
        {
            buttonPressed.Play();
            CurrentTime = 0;
            restartButton.SetActive(false);
            _timertext.SetActive(false);
            _menu.SetActive(true);
            quitButton.SetActive(true);
        }
    }

    public void RuleShow()
    {
        buttonPressed.Play();
        _menu.SetActive(false);
        rulesMenu.SetActive(true);
        backButton.SetActive(true);
    }

    public void Back()
    {
        buttonPressed.Play();
        rulesMenu.SetActive(false);
        _menu.SetActive(true);
        backButton.SetActive(false);
    }

    public void QuitGame()
    {
        buttonPressed.Play();
        Application.Quit();
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
