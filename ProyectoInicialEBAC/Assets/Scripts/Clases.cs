using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Clases : MonoBehaviour
{
    public float campo1;
    private bool campo2;
    protected float campo3 = 5;
    public float campo4 = 4;

    void Start()
    {
        campo1 = SumaFlotantes(campo3, campo4);
        Debug.Log(campo1);
        VuelveCeroAlNumero(out campo1);
        Debug.Log(campo1);
    }
    void Update()
    {
    }
    public float SumaFlotantes(float a, float b)
    {
        return a + b;
    }
    public void VuelveCeroAlNumero(out float numero)
    {
        numero = 0;
    }
    public int propiedad1 { get; set; }
    public int propiedad2 { get; set; }
    public float propiedadSoloLectura { get; }
}
