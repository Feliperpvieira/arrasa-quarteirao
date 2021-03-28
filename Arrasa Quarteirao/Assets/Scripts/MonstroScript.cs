using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstroScript : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public float damage;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        //Movimetacao
             //O "Raw" depois de GetAxis faz com que o personagem só mexa enquanto a tecla está pressionada
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

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
    void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<VidaScript> ().TakeDamage (damage) ;
    }
}
