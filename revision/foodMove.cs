using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class foodMove : MonoBehaviour
{
    public static float health = 30;
    public Text healthText;
    public Text WinText;
    public Text LoseText;
    

    public GameObject healthy1;
    public GameObject healthy2;

    float counter = 10;


    public GameObject junk1;
    public GameObject junk2;
    


    // Start is called before the first frame update
    void Start()
    {
      
        healthText.text = "Health: " + health.ToString();
        WinText.text = "";
        LoseText.text = "";

        
       
        for (int i = 0; i <= 5; i++)
        {
            Vector2 hpos1 = new Vector2(Random.Range(-12f, 10f), Random.Range(20, 26));
            Instantiate(healthy1, hpos1, Quaternion.identity); 
            Vector2 hpos2 = new Vector2(Random.Range(-15f, 12f), Random.Range(19, 25));
            Instantiate(healthy2, hpos2, Quaternion.identity);
            Vector2 jpos1 = new Vector2(Random.Range(-13f, 9f), Random.Range(18, 20));
            Instantiate(junk1, jpos1, Quaternion.identity);
            Vector2 jpos2 = new Vector2(Random.Range(-16f, 15f), Random.Range(16, 27));
            Instantiate(junk2, jpos2, Quaternion.identity);
        }

        

    }
        // Update is called once per frame
        void Update()
        {
        healthText.text = "Health: " + health.ToString();
        Vector2 h1pos = new Vector2(Random.Range(-7f, 5f), 26);
        
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);

                    if (hit.transform.gameObject.name.StartsWith("healthy1")|| hit.transform.gameObject.name.StartsWith("healthy2"))
                    {
                    counter--;
                     health += 5;
                     healthText.text = "Health: " + health.ToString();
                     //Instantiate(healthy1, h1pos, Quaternion.identity);

                     Destroy(hit.transform.gameObject);
                     
                     }


                if (hit.transform.gameObject.name.StartsWith("junk1") || hit.transform.gameObject.name.StartsWith("junk2"))
                {

                    health -= 5;
                    healthText.text = "Health: " + health.ToString();
                    //Instantiate(healthy1, h1pos, Quaternion.identity);

                    Destroy(hit.transform.gameObject);
                    

                }
               

            }


        }

        if (health <= 0)
        {
            WinText.text = "You lose!!";
            Time.timeScale = 0;
            SceneManager.LoadScene("Gameover");
        }

        if (health >= 60)
        {
            WinText.text = "You Win!!";
            Time.timeScale = 0;
           
        }

        



    }


    IEnumerator delay()

       
    {
        yield return new WaitForSeconds(10);
    }

}


