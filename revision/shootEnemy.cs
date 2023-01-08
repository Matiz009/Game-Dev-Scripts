using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootEnemy : MonoBehaviour
{

    public CharacterController2D controller;
    Animator anim;
    public GameObject projectile;
    public GameObject gunGO;
    public AudioSource gunSound;
    

    bool jump = false;
    bool crouch = false;

    public static bool rightarrow = false;
    public static bool leftarrow = false;

    float lefthorizontalMove = -20f;
    float righthorizontalMove = 20f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gunSound = GetComponent<AudioSource>();
        anim.SetBool("isShoot", false);
        anim.SetBool("isWalk", false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerpos =transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 gunpos = gunGO.transform.position;

            Instantiate(projectile, gunpos, Quaternion.identity);
            anim.SetBool("isShoot", true);
            gunSound.Play();

        }

        else
        {
            anim.SetBool("isShoot", false);
        }

        if (playerpos.x >=25)
        {
            playerpos.x = -13f;
            transform.position =playerpos;
        }

        else if(playerpos.x <=-19)
        {
            playerpos.x = 40f;
            transform.position = playerpos;
        }
    }

    private void FixedUpdate()
    {
        // for key input
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightarrow = true;
            leftarrow = false;
            controller.Move(righthorizontalMove * Time.fixedDeltaTime, crouch, jump);
            anim.SetBool("isWalk", true);
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rightarrow = false;
            leftarrow = true;
            controller.Move(lefthorizontalMove * Time.fixedDeltaTime, crouch, jump);
            anim.SetBool("isWalk", true);
        }

        else
        {
            anim.SetBool("isWalk", false);
        }

    }

}
