using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    [SerializeField] float JumpForce;
    bool Grounded;
    Rigidbody2D rb;
    GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Grounded = true;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && Grounded)
        {
            Jump();
        }
    }

    void Jump()
    {
       rb.AddForce(transform.up * JumpForce);
        Grounded = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Ground"))
        {
            Grounded = true;
        }

        if (col.gameObject.CompareTag("Obstacle"))
        {
            gm.Death();
        }
    }
}
