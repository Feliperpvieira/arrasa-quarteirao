using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoReiniciar : MonoBehaviour
{
    public void restartScene()
    {
        SceneManager.LoadScene("SampleScene"); //Alterar nome entre aspas para mudar qual cena o botão de reiniciar vai carregar
    }
}
