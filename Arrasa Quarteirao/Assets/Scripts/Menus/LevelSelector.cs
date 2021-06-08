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

    void Update () //Era start, mas eu mudei pra Update pra fazer o Select() continuar pra sempre. Checar outras formas pra deixar de usar isso tudo num Update
	{
		totalEstrelasMundo = 0;
		codigoDoMundo = SceneManager.GetActiveScene().name;

		int levelReached = PlayerPrefs.GetInt("levelAtual-" + codigoDoMundo);

		for (int i = 0; i < levelButtons.Length; i++)
		{
			if (i == levelReached)
			{
				levelButtons[i].Select();
			}
			if (i > levelReached)
			{
				levelButtons[i].interactable = false; //Bloqueia as fases seguintes das que você ainda não chegou
			}
			totalEstrelasMundo = totalEstrelasMundo + PlayerPrefs.GetInt(codigoDoMundo + "L" + i); //Contabiliza o total de estrelas do mundo
		}
		numeroEstrelas.text = totalEstrelasMundo.ToString();
	}

    public void SelectScene (string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

}
