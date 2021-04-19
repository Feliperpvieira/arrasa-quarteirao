using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonstroScript : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public float damage;
    public static int score;
    public Text scoreText;

    public GameObject particulasColisao;

    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; //Reseta a contagem no início de partidas
    }

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
        Instantiate(particulasColisao, transform.position, Quaternion.identity); //Inicia as particulas na colisão
        AddScore();
    }

    void AddScore()
    {
        score++;
        scoreText.text = "Pontuação: " + score.ToString();
    }

}
