using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaMeButee : MonoBehaviour
{
    public bool butee;
    // Start is called before the first frame update
    void Start()
    {
        butee = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Filet")
        {
            butee = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Filet")
        {
            butee = false;
        }
    }
}
