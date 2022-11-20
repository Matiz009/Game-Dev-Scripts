using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.8f);
        Vector3 pos = transform.position;
        if(pos.z >=200){
            pos.z= -199;
            transform.position=pos;
        }
    }
}
