using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public bool IsPlayer1;
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    private Vector3 control;
    private Transform ball;

    void Start()
    {
        ball = GameObject.FindWithTag("Ball").transform;
    }
    void Update()
    {
        if (IsPlayer1)
        {
            control = transform.position;
            control.y = ball.position.y;
            if (control.y<= 4.56 && control.y>= -3.36 && ball.position.x<= -2) {
                transform.position = control;
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
