using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public SpriteRenderer tamborRojo, tamborAzul, tamborVerde;

    public AudioSource srcRojo, srcVerde, srcAzul;
    public AudioClip sndRojo, sndAzul, sndVerde;

    public Canvas Canvas1;
    public SpriteRenderer backgroundPausa;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            //tamborVerde.GetComponent<AudioSource>().enabled = false;

            Canvas1.GetComponent<Canvas>().enabled = true;
            backgroundPausa.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Tambor Azul (abajo)
        else if (Input.GetKey(KeyCode.Space))
        {
            tamborAzul.color = Color.white;
            srcAzul.clip = sndAzul;
            srcAzul.Play();
        }

         
        //Tambor Verde (derecha)
        else if (Input.GetKey(KeyCode.Y))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.U))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }


        else if (Input.GetKey(KeyCode.I))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.O))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.P))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.H))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.J))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.K))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.L))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.N))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.B))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.M))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.Comma))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.Colon))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }

        else if (Input.GetKey(KeyCode.Semicolon))
        {
            tamborVerde.color = Color.white;
            srcVerde.clip = sndVerde;
            srcVerde.Play();
        }



        //Tambor Rojo (izquierda)


        else if (Input.GetKey(KeyCode.Tab))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.CapsLock))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.LeftShift))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.Minus))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.Q))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.W))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.E))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.R))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.T))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.A))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();

        }

        else if (Input.GetKey(KeyCode.S))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.D))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.F))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.G))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.X))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.C))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }

        else if (Input.GetKey(KeyCode.V))
        {
            tamborRojo.color = Color.white;
            srcRojo.clip = sndRojo;
            srcRojo.Play();
        }




        else
        {
            //tamborVerde.GetComponent<AudioSource>().enabled = false;
            tamborVerde.GetComponent<SpriteRenderer>();
            tamborVerde.color = Color.clear;

            //tamborAzul.GetComponent<AudioSource>().enabled = false;
            tamborAzul.GetComponent<SpriteRenderer>();
            tamborAzul.color = Color.clear;

            //tamborRojo.GetComponent<AudioSource>().enabled = false;
            tamborRojo.GetComponent<SpriteRenderer>();
            tamborRojo.color = Color.clear;


            //Canvas1.GetComponent<Canvas>().enabled = false;

        }

    }


    public void cambiaMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void resumeJuego()
    {
        Canvas1.GetComponent<Canvas>().enabled = false;
        backgroundPausa.GetComponent<SpriteRenderer>().enabled = false;
    }

    }
