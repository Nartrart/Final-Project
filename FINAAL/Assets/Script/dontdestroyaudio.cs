using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyaudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
