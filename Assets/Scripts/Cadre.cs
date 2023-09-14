using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadre : MonoBehaviour
{
    float speed;
    Vector2 velocityForward;
    bool Coroutined;
    public Transform Hareng;
    public Transform Lieu;
    public Transform Raie;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
        velocityForward = new Vector2(1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Coroutined == true)
        {
            transform.Translate(velocityForward * speed * Time.deltaTime);
        }

    }

    public void BougerLeCadre(int num)
    {
        switch (num)
        {
            case 0:
                Hareng.GetComponent<SpriteRenderer>().enabled = true;
                Lieu.GetComponent<SpriteRenderer>().enabled = false;
                Raie.GetComponent<SpriteRenderer>().enabled = false;
                StartCoroutine(CoroutineCadre());
                return; 
            case 1:
                Hareng.GetComponent<SpriteRenderer>().enabled = false;
                Lieu.GetComponent<SpriteRenderer>().enabled = true;
                Raie.GetComponent<SpriteRenderer>().enabled = false;
                StartCoroutine(CoroutineCadre());
                return;
            case 2:
                Hareng.GetComponent<SpriteRenderer>().enabled = false;
                Lieu.GetComponent<SpriteRenderer>().enabled = false;
                Raie.GetComponent<SpriteRenderer>().enabled = true;
                StartCoroutine(CoroutineCadre());
                return;
        }
    }

    IEnumerator CoroutineCadre()
    {
        Coroutined= true;
        speed = -0.7f;
        yield return new WaitForSeconds(2);
        speed = 0.0f;
        yield return new WaitForSeconds(2);
        speed = 0.7f;
        yield return new WaitForSeconds(2);
        Coroutined = false;
    }
}
