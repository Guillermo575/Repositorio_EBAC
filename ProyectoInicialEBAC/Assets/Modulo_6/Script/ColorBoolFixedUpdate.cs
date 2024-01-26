using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBoolFixedUpdate : ColorBool
{
    void FixedUpdate()
    {
        Variable = !Variable;
        Color c = Variable ? Color.white : Color.black;
        this.gameObject.GetComponent<MeshRenderer>().material.color = c;
        Debug.Log("CambiarColorFixedUpdate del objeto " + this.gameObject.name + " a color: " + (Variable ? "blanco" : "negro"));
    }
}
