using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    public int cantPuntos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TOCADO!");

        PickUpScript pickUp;
        pickUp = other.GetComponent<PickUpScript>();

        cantPuntos += pickUp.puntosItem;
        if (pickUp.esComida)
        {
            Destroy(other.gameObject);
        }
    }
}
