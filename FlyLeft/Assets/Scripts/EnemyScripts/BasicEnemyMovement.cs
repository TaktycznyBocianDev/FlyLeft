using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rb;
    GameObject player;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        Move();
        
    }

    private void Move()
    {
        rb.velocity = new Vector2(-speed, FindPlayerY()/2);
        
    }

    private float FindPlayerY()
    {
        return player.transform.position.y - transform.position.y;
    }
}
