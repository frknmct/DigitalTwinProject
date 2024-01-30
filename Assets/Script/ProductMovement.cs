using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProductMovement : MonoBehaviour
{
    public float speed;
    public float vectorScale;
    
    public int stepValue;

    public GameObject writeScript;
    

    public Product productScript;
    

    public string currentTime;
    public string exitTime;

    private void Start()
    {
        productScript = this.gameObject.GetComponent<Product>();
    }

    void Update()
    {
        Vector3 vectorScale = Vector3.left * speed * Time.deltaTime * -10;
        transform.Translate(vectorScale);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        stepValue = other.gameObject.GetComponent<IMachinee>().step;
        currentTime = DateTime.Now.ToLongTimeString();
    }

    private void OnTriggerExit(Collider other)
    {
        exitTime = DateTime.Now.ToLongTimeString();
        writeScript.GetComponent<Write>().SendInfo(productScript.productId,stepValue,currentTime,exitTime);
    }
}
