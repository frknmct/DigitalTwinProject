using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenColorMachine : MonoBehaviour
{
    public Material greenColorMaterail;
    private void OnTriggerEnter(Collider other)
    {
        ProductMovement productMovement = other.gameObject.GetComponent<ProductMovement>();
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = greenColorMaterail;
        
    }
}
