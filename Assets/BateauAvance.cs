using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateauAvance : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    Vector2 velocityAvance;
    float speed;
    float speedRotate;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocityAvance = new Vector2(0.0f, 1.0f);
        speed = 0.0f;
        speedRotate = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (speed<=1.0f)//rb.velocity.y <= 1.0f)
            {
                //rb.velocity = rb.velocity + new Vector2(0.0f, 0.02f);
                speed = speed + 0.02f;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (speed>0.0f)//.velocity.y > 0.0f)
            {
                //rb.velocity = rb.velocity - new Vector2(0.0f, 0.02f);
                speed = speed - 0.02f;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * speedRotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
        }
        transform.Translate (velocityAvance*speed*Time.deltaTime);
    }
}
