using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawndesZones : MonoBehaviour
{
    public GameObject Poisson;
    Transform Gauche;
    Transform Droite;
    float RandomX;
    float RandomY;
    float timer;
    float delai;
    Quaternion Rota;
    // Start is called before the first frame update
    void Start()
    {
        Gauche = this.transform.Find("G");
        Droite = this.transform.Find("D");
        delai = 10f;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delai)
        {
            timer = 0f;
            RandomX = Random.Range(Gauche.transform.position.x, Droite.transform.position.x);
            RandomY = Random.Range(Gauche.transform.position.y, Droite.transform.position.y);
            Instantiate(Poisson, new Vector3(RandomX, RandomY, 0f),Rota);
        }
    }
}
