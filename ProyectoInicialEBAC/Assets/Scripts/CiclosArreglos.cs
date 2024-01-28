using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CiclosArreglos : MonoBehaviour
{
    void Start()
    {
        int[] miArreglo = new int[5];
        miArreglo = new int[7];
        string[] diasSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
        ImprimirArreglos(miArreglo, diasSemana);
        diasSemana = new string[] { "miercoles", "jueves", "viernes", "sabado", "domingo" };
        ImprimirArreglos(miArreglo, diasSemana);
    }
    private void ImprimirArreglos(int[] miArreglo, string[] diasSemana)
    {
        for (int i = 0; i < diasSemana.Length; i++)
        {
            miArreglo[i] = i + 1;
            Debug.Log(miArreglo[i] + ", " + diasSemana[i]);
        }
    }
    void Update()
    {
    }
}