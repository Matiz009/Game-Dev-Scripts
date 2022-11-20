using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject explosion;
    public static float enemyCounter=0;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        explosion.SetActive(false);
        ScoreText.text = "Score: " + enemyCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(0,0,1);
    }
    private void OnCollisionEnter(Collision col){
        if(col.gameObject.name.StartsWith("enemy")){
            Destroy(col.gameObject);
            explosion.SetActive(true);
            Instantiate(explosion,transform.position,transform.rotation);
            enemyCounter+=5;
        }
            Destroy(transform.gameObject);
            ScoreText.text = "Score: " + enemyCounter.ToString();
    }
}
