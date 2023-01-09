using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
	
	public class alligatorMove : MonoBehaviour
    {
        public GameObject bullet;
        public AudioClip shotgun_firing;
        AudioSource AudioSource;
        Animator anim;
        public GameObject enemy;
        public Text ScoreTextEnemy;    
        public static float scoreEnemy = 0;
  
    
        void Start()
        {
             anim = GetComponent<Animator>();
             AudioSource = GetComponent<AudioSource>();
             ScoreTextEnemy.text = "Score: " + scoreEnemy.ToString();
        }
        void Update() 
        {
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * 100 * Time.fixedDeltaTime);
                anim.SetBool("isWalk",true);
            }
            
            if(Input.GetKeyUp(KeyCode.RightArrow))
            {
                anim.SetBool("isWalk",false);
            }

            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * 100 * Time.fixedDeltaTime);
                anim.SetBool("isWalk",true);
            }
            
            if(Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.SetBool("isWalk",false);
            }

             if(Input.GetKeyUp(KeyCode.Space))
            {
                anim.SetBool("isShoot",true);
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("isShoot",false);
            }

             if (Input.GetKeyDown(KeyCode.Space))//Instantiate Bullet
            {
                Vector2 fpsposition = transform.position;
                fpsposition.y = 1f;
                Instantiate(bullet, fpsposition, transform.rotation);
                AudioSource.PlayOneShot(shotgun_firing);
                transform.Translate(Vector3.right * Time.deltaTime * 50);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.name.StartsWith("enemy"))
            {
                    print("collison with enemy");
                    anim.SetTrigger("isEnemyDie");
                    StartCoroutine(delayTime());
                    scoreEnemy += 10;
                    ScoreTextEnemy.text = "Score: " + scoreEnemy.ToString();

                    if(scoreEnemy == 60)
                    {
                        SceneManager.LoadScene("gamewin");
                    }
            }
        }

         IEnumerator delayTime() 
        {
            yield return new WaitForSeconds(2.0f);
        }
    }
