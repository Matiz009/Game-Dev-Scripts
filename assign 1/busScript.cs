using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class busScript : MonoBehaviour
{
    public AudioClip horn;
    Rigidbody rigid;
    public Text student_count;
    public Text Health;
    int HealthValue=50;
    int students = 0;
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        GetComponent<AudioSource>().clip = horn;
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, 1.0f);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -1.0f);
        }
         if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -1.0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 1.0f, 0f);
        }
         if(Input.GetKeyDown(KeyCode.Space)){
            Destroy(child);
            students += 1;
            student_count.text = "Student Count: "+ students.ToString();
        }
         if(Input.GetKey(KeyCode.H))
        {
            GetComponent<AudioSource>().PlayOneShot(horn);
        }
    }
     private void OnCollisionEnter(Collision col){
        if (col.gameObject.name.StartsWith("Building"))
        {
            SceneManager.LoadScene("gameOver");
        }
        if (col.gameObject.name.StartsWith("drum"))
        {
            SceneManager.LoadScene("gameOver");
        }
         if (col.gameObject.name.StartsWith("vehicle"))
        {
            HealthValue-=10;
            Health.text = "Health: " + HealthValue.ToString();
        }
         if(HealthValue<=0)
            {
                SceneManager.LoadScene("gameOver");
            }
    }
}
