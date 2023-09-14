using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.PackageManager;
using UnityEngine;

public class PecherLePoisson : MonoBehaviour
{
    string Temp;
    public bool ferrer;
    float timer;
    public bool Hareng;
    public bool Lieu;
    public bool Raie;
    bool go;
    public Butee Butee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go == true) 
        {
            if (Butee.butee == true)
            {
                timer += Time.deltaTime;
                if (timer >= 5f)
                {
                    ferrer = true;
                }
                if (ferrer == true)
                {
                    switch (Temp)
                    {
                        case "Surface":
                            Hareng = true;
                            Lieu = false;
                            Raie = false;
                            print("Hareng");
                            break;
                        case "Moyen":
                            Lieu = true;
                            Raie = false;
                            Hareng = false;
                            print("Lieu");
                            break;
                        case "Profond":
                            Raie = true;
                            Hareng = false;
                            Lieu = false;
                            print("raie");
                            break;
                    }
                }
            }
        }
        if (Butee.rentree == true)
        {
            if (Hareng == true)
            {
                timer = 0f;
                ferrer = false;
                Hareng = false;
                print("Hareng péché");
            }

            if (Lieu == true)
            {
                timer = 0f;
                ferrer = false;
                Lieu = false;
                print("Lieu péché");
            }
            if (Raie == true)
            {
                print("raie péchée");
                timer = 0f;
                ferrer = false;
                Raie = false;
            }
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Temp == collision.tag)
        {
            Temp = collision.tag;
            go = true;
        }
        else
        {
            go = false;
            Temp = collision.tag;
            Hareng = false;
            Lieu = false;
            Raie = false;
            timer = 0;
        }
    }
}
