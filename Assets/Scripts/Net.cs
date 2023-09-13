using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour
{
    public BateauAvance BateauAvance;
    public Butee Butee;
    float speedFilet;
    Vector2 velocityAvance;
    Vector2 velocityRecul;
    bool Depliage;
    bool Rentre;
    public float dureteedelaremontee;
    // Start is called before the first frame update
    void Start()
    {
        velocityRecul = new Vector2(0.0f, -1.0f);
        velocityAvance = new Vector2(0.0f, 1.0f);
        Depliage = false;
        Rentre = true;
        dureteedelaremontee = 1;
    }

    // Update is called once per frame
    void Update()
    {
        speedFilet = BateauAvance.speed;
        if (Butee.butee == true)
        {
            Depliage = false;
        }
        if (Input.GetKey(KeyCode.Mouse2) && Butee.rentree==true)
        {
            print("camarche");
            Depliage=true;
        }

        if (Depliage)
        {
            transform.Translate(velocityRecul * ((speedFilet * speedFilet) / 2) * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f && Butee.rentree == false)
        {
            transform.Translate(velocityRecul *Input.GetAxis("Mouse ScrollWheel")/dureteedelaremontee);
        }
    }
}