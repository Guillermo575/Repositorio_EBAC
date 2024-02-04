using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;
public class EjerciciosEstructuras : MonoBehaviour
{
    void Start()
    {
        #region Ejercicio 1
        Debug.Log($"Ejercicio 1------------------");
        var Ejercicio1 = GetListaRandom(20, 1, 10);
        Debug.Log($"Resultado: {string.Join(",", Ejercicio1)}");
        #endregion

        #region Ejercicio 2
        Debug.Log($"Ejercicio 2 ------------------");
        var Ejercicio2 = GetListaSortDesc(Ejercicio1.ToArray());
        Debug.Log($"Resultado usando metodo de seleccion: {string.Join(",", Ejercicio2)}");
        var Ejercicio2EnLinq = Ejercicio1.OrderByDescending(x => x).ToArray();
        Debug.Log($"Resultado usando Linq: {string.Join(",", Ejercicio2EnLinq)}");
        CompararListas(Ejercicio2.ToList(), Ejercicio2EnLinq.ToList());
        #endregion

        #region Ejercicio 3
        Debug.Log($"Ejercicio 3 ------------------");
        var Ejercicio3 = GetHashSet(Ejercicio2.ToList());
        Debug.Log($"Resultado: {string.Join(",", Ejercicio3)}");
        #endregion

        #region Ejercicio 4
        Debug.Log($"Ejercicio 4 ------------------");
        Stack<string> pilaString = new Stack<string>();
        pilaString.Push("As");
        pilaString.Push("CincoEspadas");
        pilaString.Push("TresCorazones");
        pilaString.Push("CuatroTrebol");
        pilaString.Push("ReyEspadas");
        Debug.Log($"Pila: {string.Join(",", pilaString)}");
        var colaString = StackToQueue(pilaString);
        Debug.Log($"Imprimir Cola:");
        while (colaString.Count > 0)
        {
            Debug.Log(colaString.Dequeue());
        }
        Debug.Log($"------------------ Fin del ejercicio ------------------");
        #endregion
    }

    #region Metodos
    private List<int> GetListaRandom(int size, int minRange, int maxRange)
    {
        List<int> lstNuevo = new List<int>();
        for (int l = 0; l < size; l++)
        {
            lstNuevo.Add(Random.Range(minRange, maxRange));
        }
        return lstNuevo;
    }
    private int[] GetListaSortDesc(int[] lst)
    {
        for (int l = 0; l < lst.Length; l++)
        {
            for (int m = l; m < lst.Length; m++)
            {
                if (lst[l] < lst[m])
                {
                    int numTemp = lst[l];
                    lst[l] = lst[m];
                    lst[m] = numTemp;
                }
            }
        }
        return lst;
    }
    private void CompararListas(List<int> a, List<int> b)
    {
        if (a.Count != b .Count)
        {
            Debug.Log("Estas listas no son iguales");
            return;
        }
        for (int l = 0; l < a.Count; l++)
        {
            if (a[l] != b[l])
            {
                Debug.Log("Estas listas no son iguales");
            }
        }
        Debug.Log("Estas listas son iguales");
    }
    private HashSet<int> GetHashSet(List<int> lst)
    {
        HashSet<int> objNuevo = new HashSet<int>();
        foreach (var obj in lst)
        {
            objNuevo.Add(obj);
        }
        return objNuevo;
    }
    private Queue<string> StackToQueue(Stack<string> lst)
    {
        Queue<string> lstNuevo = new Queue<string>();
        while (lst.Count > 0)
        {
            lstNuevo.Enqueue(lst.Peek());
            lst.Pop();
        }
        return lstNuevo;
    }
    #endregion

}