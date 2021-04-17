using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasFases : MonoBehaviour
{
    public static bool GameIsPaused = false;
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
                Pause();
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
        SceneManager.LoadScene("SampleScene"); //Alterar nome entre aspas para mudar qual cena o botão de reiniciar vai carregar
        Time.timeScale = 1f;
    }

    public void botaoPause() //a ideia é passar essa e a debaixo pra outro arquivo, assim nao precisa ficar preenchendo os gameobjects desse arquivo toda vez que for aplicar um botao
    {
        Pause();
    }

    public void botaoResume()
    {
        Resume();
    }

}
