using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarteiraoPontos : MonoBehaviour
{
    public int bonusQuarteiraoScore;
    public GameObject txtBonusPrefab;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            Pontuacao.score = Pontuacao.score + bonusQuarteiraoScore;
            ShowPontosBonus();
            enabled = false;
        }
    }

    void ShowPontosBonus()
    {
        var go = Instantiate(txtBonusPrefab, transform.position, Quaternion.Euler(90, 0, 0));
        go.GetComponent<TextMesh>().text = "+" + bonusQuarteiraoScore.ToString();
    }

}
