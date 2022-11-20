using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class helicopterScript : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, 1.0f);
             transform.Translate(0f, 1f, 1.0f);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -1.0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 1.0f, 0f);
        }
       
         if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -1.0f, 0f);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Vector3 heliPos = transform.position;
            /*in case of any problem with the bullet we use this
                vector3 heliPos = transform.position;
                heliPos.y-=1f;
                Instantiate(bullet,hellipos,transform.rotation);

                */
            Instantiate(bullet,transform.position,transform.rotation);
        }
    }
     private void OnCollisionEnter(Collision col){
        if (col.gameObject.name.StartsWith("enemy"))
        {
            SceneManager.LoadScene("gameOver");
        }
       
    }
}
