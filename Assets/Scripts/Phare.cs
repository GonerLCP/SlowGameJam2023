using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phare : MonoBehaviour
{
    float timer;
    public bool BateauProche;
    bool commFaite;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }

        if (gameObject.GetComponent<SpriteRenderer>().enabled == true)
        {
            if (BateauProche == true)
            {
                print("Oé");
                commFaite = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            BateauProche = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            BateauProche = false;
            commFaite = false;
            timer = 0f;
        }
        if (commFaite == false)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
