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
        
    }

    // Update is called once per frame
    void Update()
    {
        totalEstrelasText.text = "Fase 0: " + PlayerPrefs.GetInt("0", 0).ToString() + ", Fase 1: " + PlayerPrefs.GetInt("1", 0).ToString() + ", Fase 2: " + PlayerPrefs.GetInt("2", 0).ToString() + ", Fase 3: " + PlayerPrefs.GetInt("3", 0).ToString() + ", Fase 4: " + ", Fase SS: " + PlayerPrefs.GetInt("SampleScene", 0).ToString();
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
