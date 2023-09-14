using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paquebot : MonoBehaviour
{
    float speed;
    Vector2 velocityForward;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.0f;
        velocityForward = new Vector2(0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 20f)
        {
            transform.Translate(velocityForward * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
