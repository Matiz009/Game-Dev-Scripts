using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControllerScript : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i<=2; i++)
        {
            Vector2 enemypos = new Vector2(Random.Range(6, -17), 0);
           Instantiate(enemy, enemypos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



