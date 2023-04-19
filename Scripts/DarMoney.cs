using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarMoney : MonoBehaviour
{
    
    public GameObject UI; //aqui ira almacenado el UI que se activara para interactuar con el cajero
    public GameObject Card;//aqui referenciamos la tarjeta


    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag ("Card"))
        {
            Debug.Log("Entro En el collider");
            UI.SetActive(true);
            Destroy(Card);        
        }

    }
}
