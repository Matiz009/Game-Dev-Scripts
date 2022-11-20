using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuLoader : MonoBehaviour
{
   public void reloadScene(){
      SceneManager.LoadScene("Main_Menu");
    }
}

