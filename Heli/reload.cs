using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class reload : MonoBehaviour
{
    public void reloadScene(){
        SceneManager.LoadScene("Helicopter game");
    }
}
