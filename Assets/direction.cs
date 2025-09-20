using UnityEngine;
using UnityEngine.WSA;

public class direction : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 startpos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Launch();
    }
    public void resetpos()
    {
        transform.position = startpos;
        rb.linearVelocity = Vector2.zero;
        Invoke("Launch", 0.5f);
    }

    // Update is called once per frame
    void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.linearVelocity = new Vector2(speed * x, speed * y);
    }
}
