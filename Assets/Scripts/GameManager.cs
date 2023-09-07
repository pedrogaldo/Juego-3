using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public SpriteRenderer tamborRojo;
    public SpriteRenderer tamborAzul;
    public SpriteRenderer tamborVerde;

    Color newColor = new Color(0.3f, 0.4f, 0.6f, 0.3f);
    public Color m_newColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;

        }

        else
        {
            tamborRojo.GetComponent<AudioSource>().enabled = false;
            tamborRojo.GetComponent<SpriteRenderer>();
            tamborRojo.color = Color.clear;
        }
    }
}
