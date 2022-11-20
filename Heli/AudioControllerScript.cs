using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioControllerScript : MonoBehaviour
{
   
    public Button MuteButton;
    public Button UnMuteButton;
    public Button PauseButton;
    public Button ResumeButton;

    public AudioSource heliAudio;
    public AudioSource bulletAudio;
    public AudioSource explosionAudio;

    public static bool muteMyGame = false;
    // Start is called before the first frame update
    void Start()
    {

        if (muteMyGame == false)
        {
            UnMuteButton.gameObject.SetActive(false);
            heliAudio.mute = false;
            bulletAudio.mute = false;
            explosionAudio.mute = false;
        }

        if (muteMyGame == true)
        {
            MuteButton.gameObject.SetActive(false);
            heliAudio.mute = true;
            bulletAudio.mute = true;
            explosionAudio.mute = true;
        }
        ResumeButton.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void muteGame()
    {
        heliAudio.mute = true;
        bulletAudio.mute = true;
        explosionAudio.mute = true;
        muteMyGame = true;
        MuteButton.gameObject.SetActive(false);
        UnMuteButton.gameObject.SetActive(true);
    }

    public void UnmuteGame()
    {
        if (muteMyGame == true)
        {
            heliAudio.mute = false;
            bulletAudio.mute = false;
            explosionAudio.mute = false;
            muteMyGame = false;
            UnMuteButton.gameObject.SetActive(false);
            MuteButton.gameObject.SetActive(true);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        muteGame();
        ResumeButton.gameObject.SetActive(true);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        //heliAudio.mute = false;
        UnmuteGame();
        ResumeButton.gameObject.SetActive(false);
    }

}