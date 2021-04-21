using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CronometroScript : MonoBehaviour
{
    [Header("Tempo da fase")]
    public float totalTime; //tempo total da fase
    float TimeDuasEstrelas; 
    float TimeTresEstrelas;
    float maximum;

    [Header("Estrelas e Barra de Progresso")]
    public GameObject EstrelaUm;
    public GameObject EstrelaDois;
    public GameObject EstrelaTres;
    public Image barraProgresso;
    static int QuantidadeEstrelas = 3;

    private float minutes;
    private float seconds;

    public Text countdownText;

    [Header("Menus e jogador")]
    public GameObject MenuMorte;
    public GameObject MenuVitoria;
    public GameObject Jogador;

    // Define os tempos para cada estrela na fase
    void Start()
    {
        maximum = totalTime; // Iguala o maximum (usado na barra de progresso) ao tempo total, mantendo apenas 1 variavel a ser definida no Unity
        TimeTresEstrelas = totalTime - ((totalTime * 60) / 100); //Calcula o tempo que tem para ganhar 3 estrelas (60%)
        TimeDuasEstrelas = totalTime - ((totalTime * 85) / 100); //Calcula o tempo que tem para ganhar 2 estrelas (85%)
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

        //if's para esconder as estrelas amarelas quando o tempo passa
        if(totalTime <= TimeTresEstrelas)
        {
            EstrelaTres.SetActive(false);
            QuantidadeEstrelas = 2;
        }
        if (totalTime <= TimeDuasEstrelas)
        {
            EstrelaDois.SetActive(false);
            QuantidadeEstrelas = 1;
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

    void GetCurrentFill() // Funcao que faz passar o tempo na barra de progresso, ao lado do cronometro
    {
        float fillAmount = (float)totalTime / (float)maximum;
        barraProgresso.fillAmount = fillAmount;
    }
}
