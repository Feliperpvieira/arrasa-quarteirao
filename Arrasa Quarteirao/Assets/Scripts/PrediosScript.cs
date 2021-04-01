using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrediosScript : MonoBehaviour
{
    public float health;
    public float currentHealth;
    public bool alive = true;
    public int bonusScore;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        currentHealth = health;
    }

    public void TakeDamage(float damageIntensity)
    {
        currentHealth -= damageIntensity;

        if (!alive) //Checa se o prédio está vivo. Se não, nada acontece. A exclamação antes de alive significa "se não está alive".
        {
            return;
        }

        if (currentHealth <= 0)
        {
            //Na linha 32 eu digo que mesmo que a vida bata um valor menor que zero, ela vai ser transformada em 0.
            //Na linha 37 eu pego a variável score que existe no script do Monstro e adiciono o bônus.
            currentHealth = 0;
            alive = false;
            gameObject.SetActive(false);
            MonstroScript.score = MonstroScript.score + bonusScore;
        }
    }
}