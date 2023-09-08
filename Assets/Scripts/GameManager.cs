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

        //Tambor Azul (abajo)
        if (Input.GetKey(KeyCode.Space))
        {
            tamborAzul.GetComponent<AudioSource>().enabled = true;
            tamborAzul.color = Color.white;
        }


        //Tambor Verde (derecha)
        else if (Input.GetKey(KeyCode.Y))
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

        else if (Input.GetKey(KeyCode.B))
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

        else if (Input.GetKey(KeyCode.Semicolon))
        {
            tamborVerde.GetComponent<AudioSource>().enabled = true;
            tamborVerde.color = Color.white;
        }



        //Tambor Rojo (izquierda)


        else if (Input.GetKey(KeyCode.Tab))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.CapsLock))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.LeftShift))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.Minus))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.Q))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.R))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.T))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;

        }

        else if (Input.GetKey(KeyCode.S))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.F))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.G))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.X))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.C))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }

        else if (Input.GetKey(KeyCode.V))
        {
            tamborRojo.GetComponent<AudioSource>().enabled = true;
            tamborRojo.color = Color.white;
        }




        else
        {
            tamborVerde.GetComponent<AudioSource>().enabled = false;
            tamborVerde.GetComponent<SpriteRenderer>();
            tamborVerde.color = Color.clear;

            tamborAzul.GetComponent<AudioSource>().enabled = false;
            tamborAzul.GetComponent<SpriteRenderer>();
            tamborAzul.color = Color.clear;

            tamborRojo.GetComponent<AudioSource>().enabled = false;
            tamborRojo.GetComponent<SpriteRenderer>();
            tamborRojo.color = Color.clear;
        }

    }
    }
