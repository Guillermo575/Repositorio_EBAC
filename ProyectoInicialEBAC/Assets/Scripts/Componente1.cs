using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Componente1 : MonoBehaviour
{
    public static GameObject miObjeto;
    private void Awake()
    {
        miObjeto = this.gameObject;
    }
    void Start()
    {
    }
    void Update()
    {
    }
}