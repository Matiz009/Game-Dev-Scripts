using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float speed = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,enemy.transform.position, speed * Time.deltaTime);
        transform.up = enemy.transform.position - transform.position;
    }
}
