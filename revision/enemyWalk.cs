using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWalk : MonoBehaviour
{
    Rigidbody2D r;
    public GameObject cheeko;
    Animator anim;
  public GameObject enemy;

    public Vector2 pos1;
    public Vector2 pos2;
    public Vector2 posdiff = new Vector2(0, 100f);
    float speed = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
        transform.Rotate(0, -180, 0);

        pos1 = transform.position;
        pos2 = pos1 + posdiff;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,-0.01f,0);
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.StartsWith("Projectile"))
        {
            anim.SetBool("isDead", true);
            Destroy(collision.gameObject);
            Vector2 enemypos = new Vector2(Random.Range(-16, 8), Random.Range(7, -7));
            Instantiate(enemy, enemypos, Quaternion.identity);

        }

        StartCoroutine(destroyOnDelay());
    }

    IEnumerator destroyOnDelay()
    {
        yield return new WaitForSeconds(1);
        Destroy(transform.gameObject);
    }

    

}
