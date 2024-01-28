using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CiclosArreglosMatriz : MonoBehaviour
{
    void Start()
    {
        int[,] miMatriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int j = 0; j < miMatriz.GetLength(0); j++)
        {
            for (int k = 0; k < miMatriz.GetLength(1); k++)
            {
                miMatriz[j, k] += 1;
                Debug.Log(miMatriz[j, k]);
            }
        }
        int[][] miArregloJagged = new int[][]
        {
            new int[]{ 1,2,3 },
            new int[]{ 4,5 },
            new int[]{ 6,7,8,9 },
        };
        miArregloJagged[1] = new int[] { 10, 11, 12, 13 };
        Debug.Log(miArregloJagged[0][1]);
        for (int x = 0; x < miArregloJagged.Length; x++)
        {
            for (int y = 0; y < miArregloJagged[x].Length; y++)
            {
                Debug.Log(miArregloJagged[x][y]);
            }
        }
        string[] diasSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
        foreach (string i in diasSemana)
        {
            Debug.Log(i);
        }
    }
    void Update()
    {
    }
}