using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    private void Awake()
    {
    }
    void Start()
    {
        Componente1.miObjeto.name = "nuevoNombreDeMiObjeto";
    }
    void Update()
    {
    }
}
