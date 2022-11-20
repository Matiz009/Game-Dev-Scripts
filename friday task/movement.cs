using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
       
        for(int i=0;i<=20;i=i+5){
             Vector3 position= new Vector3(i+i+i,1f,0);
            Instantiate(box,position,transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
