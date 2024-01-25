using UnityEngine;
public class CrearCuboUpdate : CrearCubo
{
    void Update()
    {
        ClonarCubo();
        Debug.Log("Se creo un cubo con Update()");
    }
}