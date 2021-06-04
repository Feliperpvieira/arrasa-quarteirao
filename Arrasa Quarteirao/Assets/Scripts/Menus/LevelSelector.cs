using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
	public TMP_Text numeroEstrelas;
	public string codigoDoMundo;
    public Button[] levelButtons;

	private int totalEstrelasMundo;

    void Start ()
	{
		totalEstrelasMundo = 0;

		int levelReached = PlayerPrefs.GetInt("levelAtual");

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

    public void Select (string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

}
