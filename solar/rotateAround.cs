using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Sun.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
