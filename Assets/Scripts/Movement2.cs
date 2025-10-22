using System;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public bool IsPlayer1;
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    private Transform player;
    private Transform ball;
    public float ybound1 = 4.7f;
    public float ybound2 = -2.5f;


    void Start()
    {
        ball = GameObject.FindWithTag("Ball").transform;
        
    }
    // 4.7, -2.5, -2
    void Update()
    {
        if (IsPlayer1)
        {
            if (ball.position.x< 0) {
                Vector2 targetpos = new Vector2(rb.position.x, ball.position.y);
                Vector2 newpos = Vector2.MoveTowards(rb.position, targetpos, speed * Time.deltaTime);
                newpos.y = Mathf.Clamp(newpos.y, ybound2, ybound1);
                rb.MovePosition(newpos);
            }
        }
            else
            {
                movement = Input.GetAxisRaw("Vertical2");
            }

    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0, movement*speed*Time.deltaTime);
    }
}
