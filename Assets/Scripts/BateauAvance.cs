using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.XR;

public class BateauAvance : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    Vector2 velocityAvance;
    Vector2 velocityBump;
    public float speed;
    public float maxspeed;
    float speedRotate;
    bool coroutined = true;
    public Night night;
    public AudioSource source;
    public AudioClip clip;
    bool yes;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocityAvance = new Vector2(0.0f, 1.0f);
        velocityBump = new Vector2(0.0f, -1.0f);
        speed = 0.0f;
        speedRotate = 35.0f;
        yes = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (night.Day == false)
        {
            maxspeed = 0.9f;
            if (speed > 0.9f)
            {
                speed = 0.9f;
            }
        }
        else
        {
            maxspeed = 1.2f;
        }
        if (coroutined)
        {
            if (Input.GetKey(KeyCode.W))
            {
                if (speed <= maxspeed)
                {
                    speed = speed + 0.02f;
                }
            }

            if (Input.GetKey(KeyCode.S))
            {
                if (speed > 0.0f)//.velocity.y > 0.0f)
                {
                    //rb.velocity = rb.velocity - new Vector2(0.0f, 0.02f);
                    speed = speed - 0.02f;
                }
                if (speed < 0) { speed = 0; }
            }

            if (speed > 0.25f)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(-Vector3.forward * speedRotate * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
                }
                if (yes == true)
                {
                    source.PlayOneShot(clip);
                    yes = false;
                }
            }
            else
            {
                source.Stop();
                yes = true;
            }

            transform.Translate(velocityAvance * ((speed * speed) / 2) * Time.deltaTime);
        }
        else
        {
            transform.Translate(velocityBump * speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="Exit")
        {
            StartCoroutine(CoroutineBump());    
        }
    }

    IEnumerator CoroutineBump()
    {
        coroutined = false;
        yield return new WaitForSeconds(1);
        speed=0.0f;
        coroutined= true;
    }
}
