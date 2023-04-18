using UnityEngine;
using System.Collections;

public class AbreUrl : MonoBehaviour
{
    public string url;

    public void OpenURL()
    {
        Application.OpenURL(url);
    }

}
