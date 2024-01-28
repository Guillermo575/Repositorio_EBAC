using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class EjerciciosCiclosArreglos : MonoBehaviour
{
    void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
    }

    #region Ejercicios
    private void Ejercicio1()
    {
        Debug.Log("----------EJERCICIO 1----------");
        int[] arreglo1 = new int[5];
        for (int l = 0; l < arreglo1.Length; l++)
        {
            arreglo1[l] = Random.Range(1, 10);
        }
        int[] arreglo2 = new int[arreglo1.Length];
        for (int l = 0; l < arreglo2.Length; l++)
        {
            arreglo2[l] = Random.Range(1, 10);
        }
        int[] arreglo3 = new int[arreglo1.Length - 1];
        for (int l = 0; l < arreglo3.Length; l++)
        {
            arreglo3[l] = arreglo1[l] + arreglo2[l + 1];
            Debug.Log($"{arreglo1[l]} + {arreglo2[l + 1]} = {arreglo3[l]} ");
        }
    }
    private void Ejercicio2()
    {
        Debug.Log("----------EJERCICIO 2----------");
        string[] lstEnunciados = new string[]{ "Hola", "mi", "nombre", "es", "Guillermo", "Sebastian", "Medina", "Palacios" };
        string Enunciado = string.Empty;
        foreach (var obj in lstEnunciados)
        {
            Enunciado += obj + " ";
        }
        Debug.Log($" El enunciado completo es: {Enunciado}");
    }
    private void Ejercicio3()
    {
        Debug.Log("----------EJERCICIO 3----------");
        int[,] arregloA = GetRandomArray(2, 3);
        Debug.Log($"Arreglo A: {GetSumaArreglos(arregloA)}");

        int[,] arregloB = GetRandomArray(arregloA.GetLength(1), 1);
        Debug.Log($"Arreglo B: {GetSumaArreglos(arregloB)}");

        int[,] arregloSumaAB = new int[arregloA.GetLength(0), arregloB.GetLength(1)];
        int[][] arregloJaggedDesglose = new int[arregloSumaAB.GetLength(0)][];
        for (int l = 0; l < arregloSumaAB.GetLength(0); l++)
        {
            var RowA = GetRow(arregloA, l);
            int[] ArrayDesglose = new int[RowA.Length];
            for (int m = 0; m < arregloSumaAB.GetLength(1); m++)
            {
                var ColumnB = GetColumn(arregloB, m);
                for (int n = 0; n < RowA.Length; n++)
                {
                    arregloSumaAB[l, m] += RowA[n] * ColumnB[n];
                    ArrayDesglose[n] = RowA[n] * ColumnB[n];
                }
            }
            arregloJaggedDesglose[l] = ArrayDesglose;
        }
        Debug.Log($"La multiplicacion de los arreglos A y B serian: {GetSumaArreglos(arregloJaggedDesglose)}");
        Debug.Log($"La suma los arreglos A y B serian: {GetSumaArreglos(arregloSumaAB)}");
    }
    #endregion

    #region Metodos Auxiliares
    private int[,] GetRandomArray(int rows, int columns)
    {
        int[,] arreglo = new int[rows, columns];
        for (int l = 0; l < arreglo.GetLength(0); l++)
        {
            for (int m = 0; m < arreglo.GetLength(1); m++)
            {
                arreglo[l, m] = Random.Range(1, 10);
            }
        }
        return arreglo;
    }
    private string GetSumaArreglos(int[][] arreglo1)
    {
        string SumaArreglos = string.Empty;
        SumaArreglos += "{";
        for (int x = 0; x < arreglo1.Length; x++)
        {
            SumaArreglos += "{";
            for (int y = 0; y < arreglo1[x].Length; y++)
            {
                if (y < arreglo1[x].Length - 1)
                {
                    SumaArreglos += arreglo1[x][y] + ", ";
                }
                else
                {
                    SumaArreglos += arreglo1[x][y];
                }
            }
            SumaArreglos += "}";
        }
        SumaArreglos += "}";
        return SumaArreglos;
    }
    private string GetSumaArreglos(int[,] arreglo1)
    {
        string SumaArreglos = string.Empty;
        SumaArreglos += "{";
        for (int l = 0; l < arreglo1.GetLength(0); l++)
        {
            SumaArreglos += "{" + string.Join(",", GetRow(arreglo1, l)) + "}";
        }
        SumaArreglos += "}";
        return SumaArreglos;
    }
    private int[] GetRow(int[,] arreglo1, int index)
    {
        int[] arreglo = new int[arreglo1.GetLength(1)];
        for (int m = 0; m < arreglo1.GetLength(1); m++)
        {
            arreglo[m] = arreglo1[index, m];
        }
        return arreglo;
    }
    private int[] GetColumn(int[,] arreglo1, int index)
    {
        int[] arreglo = new int[arreglo1.GetLength(0)];
        for (int m = 0; m < arreglo1.GetLength(0); m++)
        {
            arreglo[m] = arreglo1[m, index];
        }
        return arreglo;
    }
    #endregion
}