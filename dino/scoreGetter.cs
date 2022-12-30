using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class scoreGetter : MonoBehaviour
{
    public Text ScoreText;
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetFloat("Player Score");
        ScoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
