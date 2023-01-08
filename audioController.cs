using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class audioController : MonoBehaviour
{

    public AudioSource heliAudio;


    public static bool muteMyGame = false;
    // Start is called before the first frame update
    void Start()
    {

        if (muteMyGame == false)
        {

            heliAudio.mute = false;
  
        }

        if (muteMyGame == true)
        {

            heliAudio.mute = true;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void muteGame()
    {
        heliAudio.mute = true;
        muteMyGame = true;
    }

    public void UnmuteGame()
    {
       
        heliAudio.mute = false;
        muteMyGame = false;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        muteGame();

    }

     public void ResumeGame()
    {
        Time.timeScale = 1;
        UnmuteGame();
        //ResumeButton.gameObject.SetActive(false);
    }

}