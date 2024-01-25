using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CrearCubo : MonoBehaviour
{
    public GameObject PrefabCube;
    public float factorDeEscalamiento;
    private List<GameObject> listaDeCubos = new List<GameObject>();
    private int numCubos = 0;
    public void ClonarCubo()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        tempGameObject.name = "Cubo Numero " + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
        listaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;
            if (escala <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }
        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}