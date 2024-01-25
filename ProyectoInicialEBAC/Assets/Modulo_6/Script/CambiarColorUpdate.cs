using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CambiarColorUpdate : MonoBehaviour
{
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        this.gameObject.GetComponent<MeshRenderer>().material.color = c;
        Debug.Log("Se cambio el color con Update()");
    }
}