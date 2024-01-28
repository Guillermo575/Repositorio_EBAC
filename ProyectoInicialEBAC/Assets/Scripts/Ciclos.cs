using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ciclos : MonoBehaviour
{
    int contador = 0;
    void Start()
    {
        for (int i = 10; i > 1; i--)
        {
            Debug.Log(i);
        }
        bool miBooleano = false;
        while (miBooleano)
        {
            contador++;
            Debug.Log("Hola");
        }
        do
        {
            Debug.Log("Hola desde el do while");
        } while (miBooleano);
    }
    void Update()
    {
    }
}