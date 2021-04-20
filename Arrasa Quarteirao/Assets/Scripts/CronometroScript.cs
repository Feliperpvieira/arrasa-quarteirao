using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CronometroScript : MonoBehaviour
{
    public float totalTime;
    float TimeDuasEstrelas;
    float TimeTresEstrelas;
    float current;

    public GameObject EstrelaUm;
    public GameObject EstrelaDois;
    public GameObject EstrelaTres;
    public Image barraProgresso;

    private float minutes;
    private float seconds;

    public Text countdownText;

    public GameObject MenuMorte;
    public GameObject MenuVitoria;
    public GameObject Jogador;

    // Start is called before the first frame update
    void Start()
    {
        MenuMorte.SetActive(false); //Esconde a tela de morte no início das partidas
        current = totalTime;
        TimeTresEstrelas = totalTime - ((totalTime * 60) / 100);
        TimeDuasEstrelas = totalTime - ((totalTime * 85) / 100);
    }

    // Update is called once per frame
    public void Update()
    {
        totalTime -= 1 * Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);

        GetCurrentFill();

        countdownText.text = minutes.ToString() + ":" + seconds.ToString("00");

        if (totalTime <= 0)
        {
            totalTime = 0;
            EstrelaUm.SetActive(false);
            FimDeJogo();
        }

        if(totalTime <= TimeTresEstrelas)
        {
            EstrelaTres.SetActive(false);
        }
        if (totalTime <= TimeDuasEstrelas)
        {
            EstrelaDois.SetActive(false);
        }

        if (Pontuacao.score >= Pontuacao.scoreVitoriaStatic)
        {
            Vitoria();
        }
    }

    public void FimDeJogo()
    {
        //Debug.Log("Funcao fim de jogo chamada");
        MenuMorte.SetActive(true);
        Jogador.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Vitoria()
    {
        MenuVitoria.SetActive(true);
        Time.timeScale = 0f;
    }

    void GetCurrentFill()
    {
        float fillAmount = (float)totalTime / (float)current;
        barraProgresso.fillAmount = fillAmount;
    }
}
