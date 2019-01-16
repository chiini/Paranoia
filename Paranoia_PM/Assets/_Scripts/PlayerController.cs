using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Debug.Log(rb.velocity);

        //Vector3 movement = new Vector3(1, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
        rb.velocity = new Vector3(1 * speed,0,0);
    }
}