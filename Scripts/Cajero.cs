using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajero : MonoBehaviour
{
    
    public Contenedor contenedor;
    public List<int> numeros;

    public void CincoMil()
    {
        contenedor.monto += 5000;
    }

    public void diezmil()
    {
        contenedor.monto += 10000;
    }

    public void quincemil()
    {
        contenedor.monto += 15000;
    }

    public void veintemil()
    {
        contenedor.monto += 20000;
    }

    public void DarDinero()
    {
        foreach (int numero in numeros)
        {
            if (numero == contenedor.monto)
            {
                Debug.Log("El numero" + contenedor.monto + "se encuentra en la lista");
            }
        }        
    }

    
}
