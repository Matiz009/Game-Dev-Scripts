using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    Animator anim;
    public CharacterController2D controller;

    public float runSpeed = 40f;
    private float startTouchPosition, endTouchPosition;

    float lefthorizontalMove = -40f;
    float righthorizontalMove = 40f;

    float speed = 0.05f;

    bool jump = false;
    bool crouch = false;


    public Text ScoreText;
    public Text HealthText;
    public GameObject coin;
    public GameObject cloud;
    public GameObject cloud1;
    public GameObject cloud2;

    public static float score = 0;
    public static float health = 50;

    

    // Start is called before the first frame update
    void Start()
    {
 
        anim = GetComponent<Animator>();
        HealthText.text = "Health: " + health.ToString();
        ScoreText.text = "Score: " + score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //for swipe Jump

        for(int i = 0; i<Input.touchCount; i++)
        {
            var touch = Input.GetTouch(i);
            if(touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position.y;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position.y;
                if(endTouchPosition > startTouchPosition)
                {
                    transform.Translate(Vector2.up * 250 * Time.fixedDeltaTime);
                }
            }
        }
    }



    private void FixedUpdate()
    {
        // left right touch

        if (Input.touchCount > 0)
        { 
            var touch = Input.GetTouch(0);
            if(touch.position.x < Screen.width/2 && touch.position.y > Screen.height / 8)
            {
                controller.Move(lefthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("isWalk", true);
            }

            if (touch.position.x > Screen.width / 2 && touch.position.y > Screen.height/8) 
            {
               
                controller.Move(righthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("isWalk", true);
            }

        }
        else
        {
            anim.SetBool("isWalk", false);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.StartsWith("cloud"))
        {
            transform.gameObject.transform.parent = cloud.transform;
        }

        if (!collision.gameObject.name.StartsWith("cloud"))
        {
            transform.gameObject.transform.parent = null;
        }

        if (collision.gameObject.name.StartsWith("cloud1"))
        {
            transform.gameObject.transform.parent = cloud1.transform;
        }

        if (collision.gameObject.name.StartsWith("cloud2"))
        {
            transform.gameObject.transform.parent = cloud2.transform;
        }



        if (collision.gameObject.name.StartsWith("Apple"))
        {
            health += 10;
            HealthText.text = "Health: " + health.ToString();
            Destroy(collision.gameObject);
           
        }
        if (collision.gameObject.name.StartsWith("coin"))
        {
            score += 10;
            Destroy(collision.gameObject);
            ScoreText.text = "Score: " + score.ToString();
           
        }



        if (collision.gameObject.name.StartsWith("Saw"))
        {
            health -= 10;
            HealthText.text = "Health: " + health.ToString();
           if(health == 0)
            {
                HealthText.gameObject.SetActive(false);
                anim.SetTrigger("TriggerDead");
                PlayerPrefs.SetFloat("Player Score", score);
                SceneManager.LoadScene("GameOver");
            }
        }
    }


}
