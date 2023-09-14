using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioo : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clip;
    public Phare phare;
    bool Lock;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        source.PlayOneShot(clip[i]);
        i++;
    }
    private void Update()
    {
        if(phare.BateauProche == true && Lock == true)
        {
            Lock = false;
            source.PlayOneShot(clip[i]);
            i++;
        }
        if(phare.BateauProche == false)
        {
            Lock = true;
            source.Stop();
        }
    }
}
