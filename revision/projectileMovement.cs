using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shootEnemy.rightarrow==true)
        {
            transform.Translate(0.5f, 0, 0);
        }

        if (shootEnemy.leftarrow==true)
        {
            transform.Translate(-0.5f, 0, 0);
        }




    }
}
