using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public static int score;
    public int scoreVitoria;
    public static int scoreVitoriaStatic;
    public Text scoreText; //Pontuacao do jogador
    public Text scoreVitoriaText; //Pontuacao para vencer a fase

    void Start()
    {
        score = 0; //Reseta a contagem no início de partidas
        scoreVitoriaStatic = scoreVitoria; //não é o ideal mas nao achei nada simples que funcionasse, pois precisa ser static pra acessar em outros arquivos mas static nao pode ser alterado no Unity
    }

    public void Update()
    {
        scoreText.text = score.ToString();
        scoreVitoriaText.text = "/" + scoreVitoria.ToString();
    }

    void Replace(GameObject state1, GameObject state2)
    {
        Instantiate(state2, state1.transform.position, Quaternion.identity);
        Destroy(state1);
    }
}
