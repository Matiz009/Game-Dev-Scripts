using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
        
    public Button MuteButton;
    public Button UnMuteButton;


    public GameObject MenuPanel;
    public GameObject AdPanel;
    public GameObject PopupPanel;

    public AudioSource gameaudio;

    void Start()
    {

        UnMuteButton.gameObject.SetActive(false);
        MenuPanel.SetActive(false);
        AdPanel.SetActive(false);
        PopupPanel.SetActive(false);
        
       
        
    }

    private void Update()
    {
        if (playerMovement.score >= 10)
        {
            showPopup();
        }
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        ShowMenuPanel();
        
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        MenuPanel.SetActive(false);
        AdPanel.SetActive(false);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
    }

    public void ShowAdPanel()
    {
        AdPanel.SetActive(true);
    }

    public void showPopup()
    {
        Debug.Log("score value:" + playerMovement.score);
       
            PopupPanel.SetActive(true);
        
    }

    public void muteGame()
    {
        gameaudio.mute = true;
        MuteButton.gameObject.SetActive(false);
        UnMuteButton.gameObject.SetActive(true);
    }

    public void UnmuteGame()
    {
        gameaudio.mute = false;
        UnMuteButton.gameObject.SetActive(false);
        MuteButton.gameObject.SetActive(true);
    }


}
