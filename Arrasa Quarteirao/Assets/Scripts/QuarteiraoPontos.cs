using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarteiraoPontos : MonoBehaviour
{
    public int bonusQuarteiraoScore;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            Pontuacao.score = Pontuacao.score + bonusQuarteiraoScore;
            enabled = false;
        }
    }
}
