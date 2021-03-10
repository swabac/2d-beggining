using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float startOfGunfire;
    public GameObject gunfire;

    public int damage;
   private void Start()
    {
        Invoke("Gunfire", startOfGunfire);
    }


    private void Update()
    {
        transform.Translate(Vector2.right* speed * Time.deltaTime);
        
    }


    void Gunfire()
    {
        
        Instantiate(gunfire, transform.position, transform.rotation); 

        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (collision.tag == "Enemy2")
        {
            collision.GetComponent<enemy2>().TakeDamage(damage);
            Destroy(gameObject);
        }
        
            
        




    }

}
