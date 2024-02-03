using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EstructuraDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaString = new List<string>();
    HashSet<int> hasShetInts = new HashSet<int>();
    Queue<string> colaString = new Queue<string>();
    Stack<string> pilaString = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    void Start()
    {
        AgregarArma("rifle", 7.0f);
        AgregarArma("rifle", 3.0f);
        AgregarArma("pistola", 3.0f);
        AgregarArma("escopeta", 5.0f);
        AgregarArma("riflefrancotirador", 10.0f);
        AgregarArma("cuchillo", 2.0f);
        ImprimirPoderArma("rifle");
        ImprimirPoderArma("espada");
        ImprimirPoderArma("escopeta");
    }
    public void AgregarArma(string Nombre, float valor)
    {
        if (!poderArmas.ContainsKey(Nombre))
        {
            poderArmas.Add(Nombre, valor);
        }
    }
    public void ImprimirPoderArma(string armaNombre)
    {
        float temporal = 0;
        if (poderArmas.TryGetValue(armaNombre, out temporal))
        {
            Debug.Log(poderArmas[armaNombre]);
        }
        else
        {
            Debug.Log("No existe");
        }
    }
    public void DemoListas()
    {
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(i);
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaString.Add("Diego");
        listaString.Add("Sofia");
        listaString.Add("Daniel");
        listaString.Add("Javier");
        listaString.Add("Diana");
        foreach (var nombre in listaString)
        {
            Debug.Log(nombre);
        }
        listaString.Remove("Javier");
        foreach (var nombre in listaString)
        {
            Debug.Log(nombre);
        }
        listaString = listaString.OrderBy(p => p).ToList();

        listaNumeros = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        var listaNumerosOrdenados = listaNumeros.OrderBy(p => p).ToList();
        var listaValoresGrandes = listaNumeros.Where(p => p > 10).ToList();

        for (int i = 0; i < 20; i++)
        {
            hasShetInts.Add(Random.Range(0, 10));
        }
        if (hasShetInts.Contains(5))
        {
            hasShetInts.Remove(5);
        }
        else
        {
            Debug.Log("El Hashset no contiene este elemento");
        }
        foreach (var numero in hasShetInts)
        {
            Debug.Log(numero);
        }
    }
    public void DemoColas()
    {
        colaString.Enqueue("Proyectil 1");
        colaString.Enqueue("Proyectil 2");
        colaString.Enqueue("Proyectil 3");
        colaString.Enqueue("Proyectil 4");
        colaString.Enqueue("Proyectil 5");
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
    }
    public void DemoPilas()
    {
        pilaString.Push("As");
        pilaString.Push("CincoEspadas");
        pilaString.Push("TresCorazones");
        pilaString.Push("CuatroTrebol");
        pilaString.Push("ReyEspadas");
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
    }
    void Update()
    {
    }
}