using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource srcRojo, srcVerde, srcAzul;
    public AudioClip sndRojo, sndAzul, sndVerde;

    public Canvas Canvas1;
    public SpriteRenderer backgroundPausa;
    public Color colorPausa = Color.black;



    // Start is called before the first frame update
    void Start()
    {
        Canvas1.GetComponent<Canvas>().enabled = false;
        Canvas1.GetComponent<SpriteRenderer>().enabled = false;


        colorPausa = Color.black;
        colorPausa.a = 0.43f;
        backgroundPausa.GetComponent<SpriteRenderer>().color = colorPausa;

    }

    // Update is called once per frame
    void Update()
    {
        //menu pausa
        if (Canvas1.GetComponent<Canvas>().enabled == true)
        {
            Canvas1.GetComponent<AudioSource>().enabled = true;
            //Canvas1.GetComponent<SpriteRenderer>().color = colorPausa;
            Canvas1.GetComponent<Canvas>().enabled = true;

            backgroundPausa.GetComponent<SpriteRenderer>().enabled = true;


        }

        if (Canvas1.GetComponent<Canvas>().enabled == false)
        {
            Canvas1.GetComponent<AudioSource>().enabled = false;
            backgroundPausa.GetComponent<SpriteRenderer>().color = Color.clear;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Canvas1.GetComponent<Canvas>().enabled = true;
            backgroundPausa.GetComponent<SpriteRenderer>().enabled = true;

            backgroundPausa.GetComponent<SpriteRenderer>().color = colorPausa;

            Canvas1.GetComponent<AudioSource>().enabled = true;
        }
        //



        //Tambor Azul (abajo)
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            srcAzul.clip = sndAzul;
            srcAzul.PlayOneShot(sndAzul);
        }


        //Tambor Verde (derecha)
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.U))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }


        else if (Input.GetKeyDown(KeyCode.I))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.O))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.J))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.K))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.Comma))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.Colon))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }

        else if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            srcVerde.clip = sndVerde;
            srcVerde.PlayOneShot(sndVerde);
        }



        //Tambor Rojo (izquierda)


        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.Minus))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.Q))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);

        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.G))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.Z))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }

        else if (Input.GetKeyDown(KeyCode.V))
        {
            srcRojo.clip = sndRojo;
            srcRojo.PlayOneShot(sndRojo);
        }




        else
        {
            //tamborVerde.GetComponent<AudioSource>().enabled = false;

            //tamborAzul.GetComponent<AudioSource>().enabled = false;

            //tamborRojo.GetComponent<AudioSource>().enabled = false;


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
