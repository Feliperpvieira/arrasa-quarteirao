using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonstroScript : MonoBehaviour
{
    [Header("Monstro specs")]
    public float speed;
    public float rotationSpeed;
    public float damage;

    [Header("Partículas ao colidir")]
    public GameObject particulasColisao;

    //Variaveis usadas na Movimentacao
    float horizontal;
    float vertical;

    // Update is called once per frame
    void Update()
    {

        //Movimetacao
        if (Input.touchCount > 0)
        {
            horizontal = JoystickController.joystickInput.x;
            vertical = JoystickController.joystickInput.y;
        }
        else
        {
            horizontal = Input.GetAxisRaw("Horizontal"); //O "Raw" depois de GetAxis faz com que o personagem só mexa enquanto a tecla está pressionada
            vertical = Input.GetAxisRaw("Vertical");
        }
            

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        movementDirection.Normalize();

        //Rotacao
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    //Causar Dano
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PrediosScript> ().TakeDamage (damage) ;
        Instantiate(particulasColisao, transform.position, Quaternion.identity); //Inicia as particulas na colisão, elas sao destruidas no script DestroyParticulas
        Pontuacao.score += 1;
    }

}
