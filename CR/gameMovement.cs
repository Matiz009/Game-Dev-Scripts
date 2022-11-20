using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameMovement : MonoBehaviour
{
    public AudioClip horn;
    Rigidbody r;
    public Text FuelText;
    public Text fuel_Alarm;
    public Text Health;
    int HealthValue=50;
    float fuelValue = 100;
    // Start is called before the first frame update
    void Start()
    {
         r = GetComponent<Rigidbody>();
        GetComponent<AudioSource>().clip = horn;
        fuel_Alarm.text = "Refill! Fuel level is low!";
        fuel_Alarm.gameObject.SetActive(false);
        FuelText.text = "Fuel: " + fuelValue.ToString();
    }
    void Update()
    {
        
       
        if(fuelValue<=0 || HealthValue<=0)
            {
                SceneManager.LoadScene("Gameover");
            }
        if(fuelValue<=20){
         fuel_Alarm.gameObject.SetActive(true);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            fuelValue -= 0.2f;
            FuelText.text = "Fuel: " + fuelValue.ToString();
            transform.Translate(0f, 0f, 1.0f);
            //r.AddForce(0, 0, 10.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            fuelValue -= 0.2f;
            FuelText.text = "Fuel: " + fuelValue.ToString();
            transform.Rotate(0f, -1.0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            fuelValue -= 0.2f;
            FuelText.text = "Fuel: " + fuelValue.ToString();
            transform.Rotate(0f, 1.0f, 0f);
        }

        if(Input.GetKey(KeyCode.H))
        {
            GetComponent<AudioSource>().PlayOneShot(horn);
        }

        

        Vector3 pos = transform.position; //repositioning
        if (pos.z >= 85)
        {
            pos.z = -89;
            transform.position = pos;
        }
    }
    private void OnCollisionEnte(Collision col){
        if (col.gameObject.name.StartsWith("MyCar"))
        {
            print("Collision Detected!");
            HealthValue-=10;
            Health.text = "Health: " + HealthValue.ToString();
        }
        if (col.gameObject.name.StartsWith("drum"))
        {
            fuelValue=100;
            FuelText.text = "Fuel: " + fuelValue.ToString();
            fuel_Alarm.gameObject.SetActive(false);
        }
    }
}