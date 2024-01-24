using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HolaMundo : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Esta es una impresion de consola usando el metodo Debug.Log()");
        Debug.LogWarning("Esta es una impresion de consola usando el metodo Debug.LogWarning()");
        Debug.LogError("Esta es una impresion de consola usando el metodo Debug.LogError()");
    }
    void Update()
    {
    }
}