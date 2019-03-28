using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Vector3 max_speed;

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") == 0) {

            rb.velocity = new Vector3(0,rb.velocity.y,rb.velocity.z);
        }

        if (Input.GetAxis("Vertical") == 0)
        {

            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        float my_speed = Vector3.Magnitude(rb.velocity);
        float Max_speed = Vector3.Magnitude(max_speed);

        if (my_speed < Max_speed)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }

    }
}