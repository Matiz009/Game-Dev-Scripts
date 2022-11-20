using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyMovement : MonoBehaviour
{
    public GameObject myplayer;
    Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim1 = GetComponent<Animator>();
        anim1.SetBool("isdead", false);
        anim1.SetBool("iswalk", true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.01f);
        transform.LookAt(myplayer.transform);
    }

    public void die()
    {
            print("dead-1!!");
            anim1.SetBool("isdead", true);
            anim1.SetBool("iswalk", false);        
    }
}
