using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MostraEstrelasFase : MonoBehaviour
{
    //Dados que ele pega do arquivo
    private string codigoDoMundo;
    private string numeroFase;
    private string nomeDaScene;
    private int quantidadeEstrelas;

    public Text textoNumeroFase;
    public GameObject Estrela1;
    public GameObject Estrela2;
    public GameObject Estrela3;

    // Start is called before the first frame update
    void Start()
    {
        codigoDoMundo = SceneManager.GetActiveScene().name; //Pega o nome da Scene (W1, W2...) pra pegar qual mundo é
        
        if (gameObject.name.Length == 14) //Aqui ele vai formar o tamanho do nome do Botão, se for numero até 9 ele pega aqui, se for número a partir de 10 é no if debaixo
        {
            numeroFase = gameObject.name[12].ToString();
        }
        else if (gameObject.name.Length == 15)
        {
            numeroFase = gameObject.name[12].ToString() + gameObject.name[13].ToString();
        }
        quantidadeEstrelas = PlayerPrefs.GetInt(codigoDoMundo + "L" + numeroFase);
        nomeDaScene = codigoDoMundo + "-Level " + numeroFase;
        textoNumeroFase.text = numeroFase;

        //Debug.Log(quantidadeEstrelas);

        if (quantidadeEstrelas == 3)
        {
            Estrela3.SetActive(true);
        }
        if (quantidadeEstrelas >= 2)
        {
            Estrela2.SetActive(true);
        }
        if (quantidadeEstrelas >= 1)
        {
            Estrela1.SetActive(true);
        }
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(nomeDaScene);
    }
}
