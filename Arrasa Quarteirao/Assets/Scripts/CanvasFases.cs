using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasFases : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [Header("Elementos da tela")]
    public GameObject pauseBotao;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused){
                Resume();
            }
            else
            {
               if (Time.timeScale != 0f) //Não é bonito mas foi o jeito mais fácil de impedir que o menu de pausa seja acionado pela tecla ESC nas telas de vitória/derrota, pois (atualmente) elas deixam o timescale = 0f
               {
                 Pause();
               }    
            }
        }
    }

    public void Resume()
    {
        pauseBotao.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseBotao.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   //Entre parenteses ta o código que pega o nome da fase atual, para sempre reiniciar a fase que o jogador esta
        Time.timeScale = 1f;
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("LevelSelect");
    }

}
