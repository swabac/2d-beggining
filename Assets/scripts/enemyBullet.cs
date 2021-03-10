using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    private Player playerScript;
    private Vector2 targetPosition;

    public float Speed;
    public int damage;
    private void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        targetPosition = playerScript.transform.position;
    }

    
    void Update()
    {
        if(Vector2.Distance(transform.position,targetPosition) > .1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            playerScript.TakeDamage(damage);
            Destroy(gameObject);
        }

    }

}
