using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    public float jumpForce = 20f;
    public float movementSpeed;
    private Rigidbody2D rb;
    float mx;
    public LayerMask groundLayers;
    public PlayerFeet playerFeet;
    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown("space") && playerFeet.IsGrounded())
        {
            Jump();
        }
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate() 
        {
        float mvmSpeed = playerFeet.IsGrounded() ? movementSpeed : movementSpeed / 2;
        Vector2 movement = new Vector2(mx * mvmSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
    void Jump()
    {
        Vector2 movement = new Vector2(0, jumpForce);
        rb.velocity += movement;
    }

    public void Die()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if(enemy != null)
        {
            Die();
        }
    }


}



