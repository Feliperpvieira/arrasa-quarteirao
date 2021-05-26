using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuInicial : MonoBehaviour
{

    public static int totalEstrelas;
    public Text totalEstrelasText;

    // Start is called before the first frame update
    void Start()
    {
        totalEstrelasText.text = "Fase 0: " + PlayerPrefs.GetInt("W1L0", 0).ToString() + ", Fase 1: " + PlayerPrefs.GetInt("W1L1", 0).ToString() + ", Fase 2: " + PlayerPrefs.GetInt("W1L2", 0).ToString() + ", Fase 3: " + PlayerPrefs.GetInt("W1L3", 0).ToString() + ", Fase SS: " + PlayerPrefs.GetInt("W1L4", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JogarBotao()
    {
        SceneManager.LoadScene("LevelSelect");
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
