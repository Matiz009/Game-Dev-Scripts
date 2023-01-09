using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
	public class bulletController : MonoBehaviour
	{
        public GameObject bullet;
        public AudioClip shotgun_firing;
        AudioSource AudioSource;
        void Start()
        {
            AudioSource = GetComponent<AudioSource>();
        }
        void Update() 
        {
           
            
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.name.StartsWith("enemy"))
            {
                print("collison with enemy");
                // anim.SetTrigger("isDead");
            }
        }
    }




