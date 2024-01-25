using UnityEngine;
public class CrearCuboEnable : CrearCubo
{
    void OnEnable()
    {
        ClonarCubo();
        Debug.Log("Se creo un cubo con OnEnable()");
    }
    void OnDisable()
    {
        ClonarCubo();
        Debug.Log("Se creo un cubo con OnDisable()");
    }
}