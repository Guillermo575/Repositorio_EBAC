using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EjemploSwitch : MonoBehaviour
{
    int valor1 = 5;
    int limiteInferior = 0;
    int limiteSuperior = 10;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }
    void Start()
    {
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        switch (valor1)
        {
            case (int)SeleccionColor.rojo: Debug.Log("El color seleccionado es rojo"); break;
            case (int)SeleccionColor.verde: Debug.Log("El color seleccionado es verde"); break;
            case (int)SeleccionColor.azul: Debug.Log("El color seleccionado es azul"); break;
            case (int)SeleccionColor.blanco: Debug.Log("El color seleccionado es blanco"); break;
            case (int)SeleccionColor.gris: Debug.Log("El color seleccionado es gris"); break;
            default: Debug.Log("Ese no es un color valido"); break;
        }
        valor1 = Random.Range(-limiteSuperior, limiteSuperior);
        string resultado = (valor1 >= 0) ? "El valor es positivo" : "el valor es negativo";
    }
}