using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBulletScript : MonoBehaviour
{
    [SerializeField] float bulletForce;

    Vector2 direction;
    public Vector2 SetDirection(Vector2 direction) => this.direction = direction;
    

    private void Awake()
    {
        GetComponent<Rigidbody2D>().AddForce(direction * bulletForce, ForceMode2D.Impulse);
    }
}
