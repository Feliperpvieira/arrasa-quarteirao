using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuarteiraoPontos : MonoBehaviour
{
    public int bonusQuarteiraoScore;
    public GameObject txtBonusPrefab;
    public AudioClip destroyedBlockFX;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            Pontuacao.score = Pontuacao.score + bonusQuarteiraoScore;
            SoundFXManager.instance.PlaySoundFXClip(destroyedBlockFX, transform, 1f);
            ShowPontosBonus();
            enabled = false;
        }
    }

    void ShowPontosBonus()
    {
        Vector3 posicao = transform.position;
        posicao.y = 6f; //define o y em um ponto mais alto que a construcao para que o texto seja visivel

        var go = Instantiate(txtBonusPrefab, posicao, Quaternion.Euler(90, 0, 0));
        go.GetComponent<TMP_Text>().text = "+" + bonusQuarteiraoScore.ToString();
    }

}
