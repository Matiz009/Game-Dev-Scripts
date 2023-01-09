using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject girl;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - girl.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = girl.transform.position + offset;
    }
}