using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float health;
    public float currentHealth;
    public bool alive = true;

    void Start()
    {
        alive = true;
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {

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
            currentHealth = 0;
            alive = false;
            gameObject.SetActive (false);
        }
    }
}
