using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
      Animator characterAnimation;
      public AudioClip walkSound;
    // Start is called before the first frame update
    void Start()
    {
        characterAnimation = GetComponent<Animator>();
        characterAnimation.SetBool("isWalk", false);
        characterAnimation.SetBool("isJump", false);
        GetComponent<AudioSource>().clip = walkSound;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            print("walk");
            characterAnimation.SetBool("isWalk", true);
            // transform.Translate(0,0,1f);   
            GetComponent<AudioSource>().PlayOneShot(walkSound);
        }
         if(Input.GetKey(KeyCode.J))
        {
            print("jump");
            characterAnimation.SetBool("isJump", true);
            // transform.Translate(0,0,1f);   
        }
        else {
            // characterAnimation.SetBool("isWalk", false);
            // characterAnimation.SetBool("isJump", false);        
        }
    }
}

