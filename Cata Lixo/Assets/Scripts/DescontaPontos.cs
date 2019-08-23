using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescontaPontos : MonoBehaviour
{
    public GameObject Player, canvas;

    public GameObject moeda1;

    public GameObject moeda2;

    public GameObject moeda3;

    int pontos = 0;

    public int pontosmorte = 3;

    public Text txtPontos;

    int pontuacao;

    GameController gamecon;




    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            pontos++;
        }
        if (collision.gameObject.CompareTag("lixoazul"))
        {
            pontuacao += 10;
        }

        if (collision.gameObject.CompareTag("Lixo"))
        {
            pontosmorte -= 1;
        }
        if (collision.gameObject.CompareTag("Lixo")&&pontosmorte==2)
        {
            Destroy(moeda1);
          
        }
        if (collision.gameObject.CompareTag("Lixo") && pontosmorte == 1)
        {
            Destroy(moeda2);

        }
        if (collision.gameObject.CompareTag("Lixo") && pontosmorte == 0)
        {
            Destroy(moeda3);

        }
        
    

    }

    public void Update()
    {
        if(pontosmorte == 0)
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
            
        }        
       
        if (pontosmorte >= 1)
        {
            Time.timeScale = 1; 
            canvas.SetActive(false);
        }

        txtPontos.text = "Pontos: " + pontuacao;


    }
}
