using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform PlayerTransform;
    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f; 

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 pos = PlayerTransform.position + _cameraOffset;

        pos.z = Mathf.Clamp(pos.z, -1f, 6f);
        //Debug.Log(pos.z);

        pos.x = Mathf.Clamp(pos.x, 2.7f, 2.7f);

        transform.position = pos;



        //Vector3 newPos = PlayerTransform.position + _cameraOffset;

        //transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

    }
}
