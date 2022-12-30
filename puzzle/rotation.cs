using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
     

    // Start is called before the first frame update
    private void Start()
    {
            int []array = new [] {90, 180,-90,-180};

            int randomValue = Random.Range(0,3);
            transform.Rotate(0, 0, array[randomValue]);

            print(array[0]);
            print(array[1]);
            print(array[2]);
            print(randomValue);
            



    }
    
    private void OnMouseDown()
    {
        if(!playerController1.youWin)
        transform.Rotate(0,0,90);
    }
  
 }