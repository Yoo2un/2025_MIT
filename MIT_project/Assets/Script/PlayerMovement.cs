using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody2D Rigidbody2D;

    private void Start()
    {
        
    }

    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        //float yInput = Input.GetAxis("Vertical");
        
        if(Mathf.Abs(xInput) > 0)
        {
            Rigidbody2D.velocity = new Vector2(xInput*speed, Rigidbody2D.velocity.y);
        }
        //if(Mathf.Abs (yInput) > 0)
        //{
        //    Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, yInput * speed);
        //}
    }

}
