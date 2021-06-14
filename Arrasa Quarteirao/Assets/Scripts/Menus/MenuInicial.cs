using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuInicial : MonoBehaviour
{
    public TMP_Text txtNumeroEstrelas;

    //public Text totalEstrelasText;

    // Start is called before the first frame update
    void Start()
    {
        //totalEstrelasText.text = "Fase 0: " + PlayerPrefs.GetInt("W1L0", 0).ToString() + ", Fase 1: " + PlayerPrefs.GetInt("W1L1", 0).ToString() + ", Fase 2: " + PlayerPrefs.GetInt("W1L2", 0).ToString() + ", Fase 3: " + PlayerPrefs.GetInt("W1L3", 0).ToString() + ", Fase SS: " + PlayerPrefs.GetInt("W1L4", 0).ToString();
        //totalEstrelasText.text = "Fase 0: " + PlayerPrefs.GetInt("W1L0", 0).ToString() + ", Fase 1: " + PlayerPrefs.GetInt("W1L1", 0).ToString() + " || Fase atual: " + PlayerPrefs.GetInt("levelAtual-W1").ToString();
        
        txtNumeroEstrelas.text = LevelSelector.totalEstrelasMundo.ToString(); //Não funciona direito pq depende do LevelSelector já ter rodado na scene seguinte, corrigir no futuro
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JogarMundo1()
    {
        SceneManager.LoadScene("W1");
    }

    public void SelecaoMundos()
    {
        SceneManager.LoadScene("MenuMundos");
    }

    public void VaiProMenuInicial()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
