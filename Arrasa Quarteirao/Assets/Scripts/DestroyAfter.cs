using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{

    public float tempoDestruir = 3f;

    void Start()
    {
        Destroy(gameObject, tempoDestruir); //Vai destruir o gameObject que estiver com esse código após tempoDestruir segundos
    }

}
