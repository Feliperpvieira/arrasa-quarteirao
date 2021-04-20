using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public static int score;
    public int scoreVitoria;
    public static int scoreVitoriaStatic;
    public Text scoreText;

    void Start()
    {
        score = 0; //Reseta a contagem no início de partidas
        scoreVitoriaStatic = scoreVitoria; //não é o ideal mas nao achei nada simples que funcionasse
    }

    public void Update()
    {
        scoreText.text = score.ToString() + "/" + scoreVitoria.ToString();
    }

    void Replace(GameObject state1, GameObject state2)
    {
        Instantiate(state2, state1.transform.position, Quaternion.identity);
        Destroy(state1);
    }
}
