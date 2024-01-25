using UnityEngine;
public class CrearCuboAwake : CrearCubo
{
    void Awake()
    {
        ClonarCubo();
        Debug.Log("Se creo un cubo con Awake()");
    }
    void Update()
    {
    }
}