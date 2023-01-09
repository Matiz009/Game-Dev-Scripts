using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinInitiator : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<=10; i++)
        {
            Vector2 coinPos = new Vector2(Random.Range(1, 70), Random.Range(3, 6));
            Instantiate(coin, coinPos, Quaternion.identity);
        }
    }
}
