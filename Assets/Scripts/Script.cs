//1.Crear un programa que permita ingresar por inspector dos valores enteros y responda si son iguales o no lo son
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int num1;
    public int num2;
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else if (num1 != num2)
        {
            Debug.Log("Los numeros son distintos");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
