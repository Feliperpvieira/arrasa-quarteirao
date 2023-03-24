using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrediosScript : MonoBehaviour
{
    public float health;
    public float currentHealth;
    public bool alive = true;
    public int bonusScore;

    private int pontosGanhos = 0; //salva a quantidade de pontos ganhos para exibir na tela

    public GameObject inicialState;
    public GameObject destroyed;

    [Header("Partículas emitidias")]
    public GameObject particulasColisao;
    public GameObject particulasDestruicao;
    public GameObject txtPontuacaoPrefab;
    public float alturaTextoPontos; //altura em que o texto vai aparecer na cena

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        currentHealth = health;
    }

    public void TakeDamage(float damageIntensity)
    {
        currentHealth -= damageIntensity;
        Instantiate(particulasColisao, transform.position, Quaternion.identity);
        pontosGanhos = 1;

        if (!alive) //Checa se o prédio está vivo. Se não, nada acontece. A exclamação antes de alive significa "se não está alive".
        {
            return;
        }

        if (currentHealth <= 0)
        {
            //Na linha 32 eu digo que mesmo que a vida bata um valor menor que zero, ela vai ser transformada em 0.
            //Na linha 37 eu pego a variável score que existe no script do Monstro e adiciono o bônus.
            currentHealth = 0;
            alive = false;
            gameObject.SetActive(false);
            Pontuacao.score = Pontuacao.score + bonusScore;
            pontosGanhos = bonusScore;
            Instantiate(particulasDestruicao, transform.position, Quaternion.identity);
            Replace(inicialState, destroyed);
        }

        ShowPontosGanhos(pontosGanhos);
    }
    
    //Trocar o estado do prédio de Inteiro pra Destruído
    void Replace(GameObject state1, GameObject state2) {
        Instantiate(state2, state1.transform.position, state1.transform.rotation); //pega a posição e rotação do prédio anterior e replica no novo
        Destroy(state1);
    }

    void ShowPontosGanhos(int pontuacao)
    {
        Vector3 posicao = transform.position;
        posicao.y = alturaTextoPontos; //define o y em um ponto mais alto que a construcao para que o texto seja visivel
        var go = Instantiate(txtPontuacaoPrefab, posicao, Quaternion.Euler(90, 0, 0));
        go.GetComponent<TMP_Text>().text = "+" + pontuacao.ToString();
    }
}