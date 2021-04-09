using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CronometroScript : MonoBehaviour
{
    public float totalTime;

    private float minutes;
    private float seconds;

    public Text countdownText;

    public GameObject MenuMorte;
    public GameObject Jogador;

    // Start is called before the first frame update
    void Start()
    {
        MenuMorte.SetActive(false); //Esconde a tela de morte no início das partidas
    }

    // Update is called once per frame
    public void Update()
    {
        totalTime -= 1 * Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);

        countdownText.text = minutes.ToString() + ":" + seconds.ToString();

        if (totalTime <= 0)
        {
            totalTime = 0;
            FimDeJogo();
        }
    }

    public void FimDeJogo()
    {
        //Debug.Log("Funcao fim de jogo chamada");
        MenuMorte.SetActive(true);
        Jogador.SetActive(false);
    }
}
