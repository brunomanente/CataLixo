using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Botao : MonoBehaviour
{
    public void sair()
    {
        SceneManager.LoadScene("TelaInicial");
    }

   public void carregajogo()
    {
        SceneManager.LoadScene("jogofaze1");
    }

}
