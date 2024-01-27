using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VariablesCharString : MonoBehaviour
{
    void Start()
    {
        char c = '9';
        int valorEntero = int.Parse(c.ToString());
        Debug.Log(valorEntero);
        c = 'k';
        c = '6';
        valorEntero = 0;
        if (!int.TryParse(c.ToString(), out valorEntero))
        {
            Debug.LogError("Eso no es un tipo de dato valido");
        }
        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        string tercerString = miString + " " + miSegundoString;
        string ejemploEscape = "C:\\Users\nDiego\\Documentos";
        miCaracter = miString[13];
        string miNombre = "Guillermo Sebastián";
        string misApellidos = "Medina Palacios";
        string primerApellido = misApellidos;
        string salidasuma = "mi nombre es: " + miNombre + " y mis apellidos son " + misApellidos;
        string salida = $"Mi nombre es: {miNombre} y mis apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log(salida);
        Debug.Log(primerApellido);
    }
    void Update()
    {
    }
}