using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDesceParede: MonoBehaviour
{

    public int pontuacaoParaMover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pontuacao.score >= pontuacaoParaMover)
        {
            if (transform.position.y > -3)
            {
                transform.Translate(Vector3.down * Time.deltaTime * 3f, Space.World);
            }
        }
    }
}
