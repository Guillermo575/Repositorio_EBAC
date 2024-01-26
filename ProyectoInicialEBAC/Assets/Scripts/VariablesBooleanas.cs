using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;

    // A B C    OR  AND ((A or B) and C)
    // 1 1 1    1   1           1
    // 1 1 0    1   0           0
    // 1 0 1    1   0           1
    // 1 0 0    0   0           0
    // 0 1 1    1   0           1
    // 0 1 0    1   0           0
    // 0 0 1    0   0           0
    // 0 0 0    0   0           0

    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable2 = false;
        //if (variable1 && variable2)
        //{
        //    Debug.Log("Esta variable es verdadera");
        //    Debug.Log("Ya tienes el valor de la variable 1");
        //}
        //if (variable1 || variable2)
        //{
        //    Debug.Log("Esta variable es verdadera");
        //}
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operacion 1 es verdadera");
        }
        if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("La variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es verdadera");
        }
        if ((variable3 && variable2) || variable1)
        {
            Debug.Log("La operacion 3 es verdadera");
        }
        if (valor1 <= 5)
        {
            Debug.Log("el valor de la variable es menor o igual a 5");
        }
    }
}