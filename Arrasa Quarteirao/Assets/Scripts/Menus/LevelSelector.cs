using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
	public TMP_Text numeroEstrelas;
	private string codigoDoMundo;
    public Button[] levelButtons;

	private int totalEstrelasMundo;

    void Start ()
	{
		totalEstrelasMundo = 0;
		codigoDoMundo = SceneManager.GetActiveScene().name;

		int levelReached = PlayerPrefs.GetInt("levelAtual-" + codigoDoMundo);

		for (int i = 0; i < levelButtons.Length; i++)
		{
			if (i > levelReached)
			{
				levelButtons[i].interactable = false;
			}
			totalEstrelasMundo = totalEstrelasMundo + PlayerPrefs.GetInt(codigoDoMundo + "L" + i);
		}
		numeroEstrelas.text = totalEstrelasMundo.ToString();
	}

    /*public void Select (string levelName)
    {
        SceneManager.LoadScene(levelName);
    }*/

}
