using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController1 : MonoBehaviour
{

    public Transform[] pictures;
    public static bool youWin;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        win.text = "";
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pictures[0].rotation.z == 0 && pictures[1].rotation.z == 0 && pictures[2].rotation.z == 0 && pictures[3].rotation.z == 0 && pictures[4].rotation.z == 0 && pictures[5].rotation.z == 0 && pictures[6].rotation.z == 0 && pictures[7].rotation.z == 0 && pictures[8].rotation.z == 0 && pictures[9].rotation.z == 0 && pictures[10].rotation.z == 0 && pictures[11].rotation.z == 0 && pictures[12].rotation.z == 0 && pictures[13].rotation.z == 0 && pictures[14].rotation.z == 0 && pictures[15].rotation.z == 0)
        {
            youWin = true;
            win.text = "You Win!!!";
        }
        
    }
}