using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HolaMundoPractica : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogError("El objeto ha sido inhabilitado");
    }
}