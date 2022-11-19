using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_rocket : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {    
            horizontal = Input.GetAxis("Horizontal");
           
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

}
