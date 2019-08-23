using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int Numero;
    public GameObject[] Item;
    public int Milesimo, Segundos, segundostempo, minutostempo, milesimostempo;
    DescontaPontos descontap;
    public GameObject canvas, textovitoria;
    public Text txttempo;
    



    // Start is called before the first frame update
    void Start()
    {
        Milesimo = 60;
        Segundos = 5;
        segundostempo = 60;
        minutostempo = 60;
        milesimostempo = 200;

    }

    // Update is called once per frame
    void Update()
    {

        Milesimo -= 1;
        milesimostempo -= 1;

        if (Milesimo == 0)
        {
            Segundos -= 1;
            Milesimo = 60;
            
        }
        if (milesimostempo == 0)
        {
            milesimostempo = 200;
            segundostempo -= 1;
        }
        if (segundostempo == 0)
        {
            textovitoria.SetActive(true);
            SceneManager.LoadScene("Você Venceu!!");


        }
        
        
        
        
        if (Segundos == 0)
        {
            GeradorDeItem();
            Segundos = 4;
        }
        txttempo.text = "Time: " + segundostempo;
       


    }

    public void GeradorDeItem()
    {
        Numero=Random.Range(0, 6);

        switch (Numero)
        {
            case 0:
                Instantiate(Item[0]);
                break;

            case 1:
                Instantiate(Item[1]);
                break;

            case 2:
                Instantiate(Item[2]);
                break;

            case 3:
                Instantiate(Item[3]);
                break;

            case 4:
                Instantiate(Item[4]);
                break;

            case 5:
                Instantiate(Item[5]);
                break;

            case 6:
                Instantiate(Item[6]);
                break;
        }
        
    }
}
