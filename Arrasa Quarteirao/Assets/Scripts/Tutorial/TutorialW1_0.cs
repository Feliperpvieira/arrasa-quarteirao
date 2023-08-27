using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialW1_0 : MonoBehaviour
{
    public GameObject[] telasTutorial;
    int telaAtual;

    public GameObject casaTelaPts;
    public GameObject quarteirao;

    float casaHealth;
    GameObject quarteirao0;
    public GameObject botaoPausa;

    void Start()
    {
        telaAtual = 0;
        ShowPopUp();


        
    }

    private void Update()
    {
        if (telaAtual == 1)
        {
            casaHealth = casaTelaPts.GetComponent<PrediosScript>().currentHealth;

            if (casaHealth == 15f)
            {
                ShowPopUp();
            }
        }

        if (telaAtual == 2)
        {
            quarteirao0 = quarteirao.gameObject;

            if (quarteirao0.transform.childCount == 0)
            {
                ShowPopUp();
            }
        }

        if(telaAtual == 3)
        {
            if (Pontuacao.score >= 320)
            {
                ShowPopUp();
            }
        }
           
    }


    void ShowPopUp()
    {
        Time.timeScale = 0f;
        botaoPausa.SetActive(false);
        telasTutorial[telaAtual].SetActive(true);
    }

    public void ClosePopUp()
    {
        Time.timeScale = 1f;
        telasTutorial[telaAtual].SetActive(false);
        botaoPausa.SetActive(true);
        telaAtual++;
    }

    

}
