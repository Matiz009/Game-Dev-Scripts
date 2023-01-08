using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    Vector2 mypos;
    //public Text healthtext;
    
  
    // Start is called before the first frame update
    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);
        mypos = transform.position;


        if (mypos.y <= 11)
        {

            print("end");
            Destroy(transform.gameObject);
            foodMove.health -= 5;
         
           


        }

        if (foodMove.health <= 0)
        {
           
            SceneManager.LoadScene("Gameover");
        }
    }
}
