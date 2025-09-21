using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool IsPlayer1;
    public float speed;
    public Rigidbody2D rb;
    private float movement;


    void Update()
    {
        if (IsPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0, movement*speed);
    }
}
