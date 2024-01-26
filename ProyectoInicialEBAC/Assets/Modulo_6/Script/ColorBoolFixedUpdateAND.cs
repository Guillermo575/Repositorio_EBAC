using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColorBoolFixedUpdateAND : ColorBool
{
    public ColorBool Objeto1;
    public ColorBool Objeto2;
    void FixedUpdate()
    {
        Variable = Objeto1.Variable && Objeto2.Variable;
        Color c = Variable ? Color.white : Color.black;
        this.gameObject.GetComponent<MeshRenderer>().material.color = c;
        Debug.Log("CambiarColorFixedUpdateAND del objeto " + this.gameObject.name + " a color: " + (Variable ? "blanco" : "negro"));
    }
}