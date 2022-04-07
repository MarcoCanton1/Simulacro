//2.Crear las variables necesarias para ingresar por el inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supero o no el monto de dinero disponible.Luego indicar cuanto dinero sobra o falta
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float prod1;
    public float prod2;
    public float prod3;
    public float montoD;
    float total;
    float resto;
    float faltante;
    void Start()
    {
        total = prod1 + prod2 + prod3;
        if (total <= montoD)
        {
            resto = montoD - total;
            Debug.Log("El total no supera el monto de dinero, ah sobrado $" + resto);
        }
        else if (total > montoD)
        {
            faltante = total - montoD;
            Debug.Log("El total supera el monto de dinero, por lo tanto faltan $" + faltante);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

