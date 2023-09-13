using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butee : MonoBehaviour
{
    public bool butee;
    public bool rentree;
    // Start is called before the first frame update
    void Start()
    {
        butee = false;
        rentree = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Filet")
        {
            butee = true;
            rentree = false;
        }

        if (collision.tag == "FiletRentre")
        {
            rentree = true;
            butee = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
