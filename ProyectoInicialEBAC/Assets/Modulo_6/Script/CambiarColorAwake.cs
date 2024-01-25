using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CambiarColorAwake : MonoBehaviour
{
    void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        this.gameObject.GetComponent<MeshRenderer>().material.color = c;
        Debug.Log("Se cambio el color con Awake()");
    }
}