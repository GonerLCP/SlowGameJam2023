using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Night : MonoBehaviour
{
    public SpriteRenderer Background;
    public Color ImageColor;
    private bool up = false;
    float timer;
    public bool Day;
    void Start()
    {
        ImageColor = Background.color;
        Day = true;
        //StartCoroutine(ModifyOpacity());
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 60f)
        {
            timer = 0;
            if(Day == true)
            {
                StartCoroutine(ModifyOpacity());
                Day = false;
            }
            else
            {
                StartCoroutine(Jour());
                Day = true;
            }
        }
    }
    IEnumerator ModifyOpacity()
    {
        ImageColor.a = 0; //Full Opaque
        for (int i = 0; i < 71; i++)
        {
            ImageColor.a += 0.01f;
            Background.color = ImageColor;
            yield return new WaitForSeconds(0.08f); //Wait
        }
        yield return null;
    }

    IEnumerator Jour()
    {
        //ImageColor.a = 0; //Full Opaque
        for (int i = 0; i < 71; i++)
        {
            ImageColor.a -= 0.01f;
            Background.color = ImageColor;
            yield return new WaitForSeconds(0.08f); //Wait
        }
        yield return null;
    }
}
