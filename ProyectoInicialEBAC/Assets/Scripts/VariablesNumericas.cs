using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VariablesNumericas : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte mibyte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("el valor de miByteConSigno es " + miByteConSigno);
        Debug.Log("el valor de miInt es " + miInt);
        mibyte = 200;
        miIntSinSigno = mibyte;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log("el valor de miIntSinSigno es " + miIntSinSigno);
        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("el valor de miInt es " + miInt);
        int a, b, c;
        a = 5;
        b = 10;
        c = a + b;
        float f;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        c = a / b;
        Debug.Log(c);
        f = ((float)a / (float)b);
        Debug.Log(f);
        miInt = Random.RandomRange(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("el numero " + miInt + " es par");
        }
        else
        {
            Debug.Log("el numero " + miInt + " es non");
        }
    }
    private void Update()
    {
        //miShort += 3;
        //miShort *= 2;
        //Debug.Log(miShort);
    }
}