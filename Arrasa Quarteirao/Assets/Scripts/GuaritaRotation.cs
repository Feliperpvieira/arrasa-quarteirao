using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuaritaRotation : MonoBehaviour
{
    public Animator animator;
    public bool aberto;

    //public int tempoIntervalo;
    //float angle = 90f;

    void Start()
    {
        //StartCoroutine(Coroutine());
    }

    void Update()
    {
        if (aberto)
        {
            animator.SetBool("aberto", true);
        }
        else
        {
            animator.SetBool("aberto", false);
        }
    }

    /*IEnumerator Coroutine()
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
            transform.rotation = new Quaternion(angle, 0, 0, 0);
            yield return new WaitForSeconds(tempoIntervalo);
        }
    }*/

}
