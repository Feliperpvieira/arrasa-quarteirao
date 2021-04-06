using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstroManager : MonoBehaviour
{

    #region Singleton

    public static MonstroManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

}
