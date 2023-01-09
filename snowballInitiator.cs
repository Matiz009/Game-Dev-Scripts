using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballInitiator : MonoBehaviour
{
     public GameObject snowball;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<=10; i++)
        {
            Vector2 ballPos = new Vector2(Random.Range(1, 70), Random.Range(-2, 4));
            Instantiate(snowball, ballPos, Quaternion.identity);
        }
    }

}
