using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform PlayerTransform;
    private Vector3 _cameraOffset;

    [Header("Distância vertical")]
    public float zMax;
    public float zMin;

    [Header("Distância horizontal")]
    public float xMax;
    public float xMin;

    //[Range(0.01f, 1.0f)]
    //public float SmoothFactor = 0.5f; 

    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    void LateUpdate()
    {

        Vector3 pos = PlayerTransform.position + _cameraOffset;

        pos.z = Mathf.Clamp(pos.z, zMin, zMax);
        //Debug.Log(pos.z);

        pos.x = Mathf.Clamp(pos.x, xMin, xMax);
        transform.position = pos;



        //Vector3 newPos = PlayerTransform.position + _cameraOffset;

        //transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

    }
}
