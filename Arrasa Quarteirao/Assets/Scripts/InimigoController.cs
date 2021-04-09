using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InimigoController : MonoBehaviour {

    public float lookRadius = 10f;

    public GameObject MenuMorte;
    public GameObject Jogador;

    Transform target;
    NavMeshAgent agent;

    void Start()
    {
        target = MonstroManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();

        MenuMorte.SetActive(false); //Desativa o menu de morte no início de partidas
    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
    }

    //Desenha esfera vermelha com o tamanho do raio de busca utilizado ao selecionar o "Inimigo"
    void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.red; 
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    //Morrer ao encostar no inimigo
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Player")) 
        {
            FimDeJogo();
        }
    }

    public void FimDeJogo()
    {
        MenuMorte.SetActive(true);
        Jogador.SetActive(false);
    }

}
