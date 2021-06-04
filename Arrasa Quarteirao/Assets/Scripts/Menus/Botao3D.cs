using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))] //A collider is needed to receive clicks
public class Botao3D : MonoBehaviour
{
    public UnityEvent interactEvent;
    private void OnMouseDown()
    {
        interactEvent.Invoke();
    }
}
