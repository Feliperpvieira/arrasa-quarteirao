using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuaritaRotation : MonoBehaviour
{
    public int tempoIntervalo;
    float angle = 90f;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while (true)
        {
            if (angle == 90f)
            {
                angle = -90f;
            }
            else if(angle == -90f)
            {
                angle = 90f;
            }
            transform.Rotate(angle, 0.0f, 0f);
            yield return new WaitForSeconds(tempoIntervalo);
        }
    }

}
