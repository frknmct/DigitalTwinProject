using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColorMachine :  MonoBehaviour 
{
    public Material redColorMaterail;
    public IMachinee _IMachinee;

    public GameObject writeScript;
    public GameObject updateScript;
    public GameObject readScript;
    
    public float _time;
    public bool hasWrittenMachineValues = false;
    
    
    
    private void Start()
    {
        
        _IMachinee = GetComponent<IMachinee>();
        hasWrittenMachineValues = false;
    }

    private void Update()
    {
        _time = Time.deltaTime;
        if (!hasWrittenMachineValues)
        {
            hasWrittenMachineValues = true;
            writeScript.GetComponent<Write>().SendMachineInfo(_IMachinee.machineId,_IMachinee.pieceCount,_IMachinee.baseMaterial);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ProductMovement productMovement = other.gameObject.GetComponent<ProductMovement>();
        _IMachinee.pieceCount++;
        updateScript.GetComponent<NewUpdateDB>().UpdateData(_IMachinee.machineId,_IMachinee.pieceCount);
    }

    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = redColorMaterail;
    }

    

    

    
}
