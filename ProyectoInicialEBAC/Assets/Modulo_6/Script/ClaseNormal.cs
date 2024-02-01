using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClaseNormal
{
    int numero1;
    int numero2;

    public ClaseNormal(int numero1, int numero2)
    {
        this.numero1 = numero1;
        this.numero2 = numero2;
    }
    public ClaseNormal(float numero1, float numero2)
    {
        this.numero1 = (int)numero1;
        this.numero2 = (int)numero2;
    }
    public int SumarEnteros()
    {
        return numero1 + numero2;
    }
    public int SumarEnteros(int a, int b)
    {
        return a + b;
    }
    public float SumarFlotantes(float a, float b)
    {
        return a + b;
    }
    public float MultiplicarFlotantes(float a, float b)
    {
        return a * b;
    }
}