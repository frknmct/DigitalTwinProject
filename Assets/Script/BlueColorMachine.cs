using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueColorMachine : MonoBehaviour
{
    public Material blueColorMaterail;
    private void OnTriggerEnter(Collider other)
    {
        ProductMovement productMovement = other.gameObject.GetComponent<ProductMovement>();
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = blueColorMaterail;
        
    }
}
