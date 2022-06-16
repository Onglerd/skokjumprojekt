using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isWalkingRight;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isWalkingRight = false;
        

    }
    private void Update() 
    {
        if(!isWalkingRight)
            {
                rb.velocity = new Vector2(2,rb.velocity.y);
                
            }
            else 
            {
                rb.velocity = new Vector2(-2,rb.velocity.y);

            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isWalkingRight)
        {
            isWalkingRight = true;

        }
        else
        {
            isWalkingRight = false;

        }
    }



}
