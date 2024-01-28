using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.PlayerLoop.PreUpdate;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int IntUpdate = 0;
    public float FloatFixedUpdate = 0;
    public String StringOriginal = "SALUDOS DESDE EBAC ME LLAMO GUILLERMO SEBASTIAN MEDINA PALACIOS";
    void Start()
    {
        #region Ejercicio #6
        string MiNombreCompleto = "GUILLERMO MEDINA PALACIOS";
        string[] ListaNombreCompleto = MiNombreCompleto.Split(' ');
        foreach (var objNombreCompleto in ListaNombreCompleto)
        {
            Debug.Log(objNombreCompleto);
        }
        #endregion

        #region Ejercicio #7
        int SumaValores = 0;
        SumaValores += RetornarNumero("124");
        SumaValores += RetornarNumero("6343");
        SumaValores += RetornarNumero("daa11");
        SumaValores += RetornarNumero("7645");
        Debug.Log($"La suma de los valores usando el metodo tryParse es: {SumaValores}");
        #endregion

        #region Ejercicio #8
        String StringPar = String.Empty;
        for (int l = 0; l < StringOriginal.Length; l++)
        {
            StringPar += l % 2 == 0 ? StringOriginal[l] : "";
        }
        Debug.Log($"La conversion de {StringOriginal} a solo caracteres par es: {StringPar}");
        #endregion

        #region Ejercicio #9
        String StringCorte5 = StringOriginal.Substring(5);
        Debug.Log($"La conversion de {StringOriginal} quitando los primeros 5 caracteres es: {StringCorte5}");
        #endregion
    }
    void Update()
    {
        #region Ejercicio #1
        IntUpdate++;
        #endregion
    }
    void FixedUpdate()
    {
        #region Ejercicio #1
        FloatFixedUpdate++; // Ejercicio #1
        #endregion

        #region Ejercicio #2
        float SumaUpdate = (int)(IntUpdate + FloatFixedUpdate);
        #endregion

        #region Ejercicio #3
        float EsImparPar = SumaUpdate % 2;
        string PalabraImparPar = EsImparPar == 1 ? "impar" : "par";
        #endregion

        #region Ejercicio #4
        Color c = Color.white;
        switch (PalabraImparPar)
        {
            case "impar": c = Color.white; break;
            case "par": c = Color.black; break;
            default: c = Color.black; break;
        }
        this.gameObject.GetComponent<MeshRenderer>().material.color = c;
        #endregion

        #region Ejercicio #5
        decimal DivisionUpdate = (IntUpdate > 0 && FloatFixedUpdate > 0) ? (decimal)IntUpdate / (decimal)FloatFixedUpdate : 0;
        #endregion

        Debug.Log($"{IntUpdate} + {FloatFixedUpdate} = {SumaUpdate}, es {PalabraImparPar}, {IntUpdate}/{FloatFixedUpdate} = {String.Format("{0:0.0000}", DivisionUpdate)}");
    }
    private int RetornarNumero(String valor)
    {
        int valorEntero = 0;
        if (!int.TryParse(valor.ToString(), out valorEntero))
        {
            Debug.LogError($"{valor} es un tipo de dato NO valido");
        }
        return valorEntero;
    }
}