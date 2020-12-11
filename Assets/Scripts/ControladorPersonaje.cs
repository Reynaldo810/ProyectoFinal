using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{ 
    public float velMov = 10f;
    private Rigidbody2D rb;
    public float jumpForce = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movimiento = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movimiento, 0, 0) * Time.deltaTime * velMov;
    
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
   