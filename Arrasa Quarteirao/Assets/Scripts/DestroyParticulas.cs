using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticulas : MonoBehaviour
{
    float delayDestruicao = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(delayDestruicao);
        Destroy(gameObject);
    }
}
