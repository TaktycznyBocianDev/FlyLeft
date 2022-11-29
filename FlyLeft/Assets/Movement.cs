using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float xBoundry;
    [SerializeField] float yBoundry;

    private Rigidbody2D rb;
    float horizantalInput;
    float verticalInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizantalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        ClampPlayerPosition();
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.velocity = new Vector2(horizantalInput * speed, verticalInput * speed);
    }

    void ClampPlayerPosition()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xBoundry, xBoundry), Mathf.Clamp(transform.position.y, -yBoundry, yBoundry), transform.position.z);
    }

}
