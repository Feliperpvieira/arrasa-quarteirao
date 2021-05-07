using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CronometroScript : MonoBehaviour
{
    [Header("Tempo da fase")]
    public float totalTime; //tempo total da fase
    float TimeDuasEstrelas; 
    float TimeTresEstrelas;
    float maximum;

    [Header("Estrelas e Barra de Progresso")]
    public GameObject[] estrelasProgresso;
    public Image barraProgresso;
    static int QuantidadeEstrelas = 3;
    public GameObject[] estrelasVitoria;

    [Header("Menus e jogador")]
    public Text countdownText;
    public GameObject MenuMorte;
    public GameObject MenuVitoria;
    public GameObject botaoPausa;
    public GameObject Jogador;

    private float minutes;
    private float seconds;

    // Define os tempos para cada estrela na fase
    void Start()
    {
        Time.timeScale = 1f;
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
            estrelasProgresso[0].SetActive(false);
            estrelasVitoria[0].SetActive(false);
            FimDeJogo();
        }

        //if's para esconder as estrelas amarelas quando o tempo passa
        if(totalTime <= TimeTresEstrelas)
        {
            estrelasProgresso[2].SetActive(false);
            estrelasVitoria[2].SetActive(false);

            QuantidadeEstrelas = 2;
        }
        if (totalTime <= TimeDuasEstrelas)
        {
            estrelasProgresso[1].SetActive(false);
            estrelasVitoria[1].SetActive(false);
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
        botaoPausa.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Vitoria()
    {
        MenuVitoria.SetActive(true);
        botaoPausa.SetActive(false);
        Time.timeScale = 0f;
        MenuInicial.totalEstrelas = MenuInicial.totalEstrelas + QuantidadeEstrelas;
        //Debug.Log("Pontuacao chamada " + MenuInicial.totalEstrelas);

        if (QuantidadeEstrelas > PlayerPrefs.GetInt(SceneManager.GetActiveScene().name, 0))
        {
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, QuantidadeEstrelas);
        }

        enabled = false;
    }

    void GetCurrentFill() // Funcao que faz passar o tempo na barra de progresso, ao lado do cronometro
    {
        float fillAmount = (float)totalTime / (float)maximum;
        barraProgresso.fillAmount = fillAmount;
    }
}
