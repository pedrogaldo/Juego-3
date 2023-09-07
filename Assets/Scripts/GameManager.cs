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

        //Tambor Azul
        if (Input.GetKey(KeyCode.Space))
        {
            tamborAzul.GetComponent<AudioSource>().enabled = true;
            tamborAzul.color = Color.white;
        }


        //tambor verde
        if (Input.GetKey(KeyCode.Y))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.U))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }


        else if (Input.GetKey(KeyCode.I))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.O))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.P))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.H))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.J))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.K))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.L))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.N))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.M))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.Comma))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.Colon))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }

        else
        {
            tamborVerde.GetComponent<AudioSource>().enabled = false;
            tamborVerde.GetComponent<SpriteRenderer>();
            tamborVerde.color = Color.clear;

            tamborAzul.GetComponent<AudioSource>().enabled = false;
            tamborAzul.GetComponent<SpriteRenderer>();
            tamborAzul.color = Color.clear;
        }

    }
    }
