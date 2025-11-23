using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10f;

    private Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -speed);
        }
        else
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        }
    }
}
