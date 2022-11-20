using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gunScript : MonoBehaviour
{
    public float range = 1000f;
    public Camera fpsCam;
    public Text score;
    public Text bullets;
    public int bulletCount=20;
    public int scoreCount=0;
    public Text danger;
    public GameObject bulletFire;
    public static bool shootFlag;    // Start is called before the first frame update
    void Start()
    {
        bulletFire.gameObject.SetActive(false);
        danger.gameObject.SetActive(false);
        shootFlag=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            bulletFire.gameObject.SetActive(true);
            Instantiate(bulletFire,transform.position,transform.rotation);
            shoot();        
        }
    }
    void shoot(){
    RaycastHit hit;
    if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit,range)){
    if(hit.transform.name=="enemy1"){
        enemyMovement enemy = hit.transform.GetComponent<enemyMovement>();
        enemy.die();
        bulletCount-=1;
        scoreCount+=1;
        score.text = "Score: "+ scoreCount.ToString();
        bullets.text= "Bullets: "+bulletCount.ToString();
        if(bulletCount<=10){
            danger.text = "Reload!";
            danger.gameObject.SetActive(true);
        }
        print("Destroyed");
    }    
}
}
}
