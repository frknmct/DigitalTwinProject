using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    public int startLineId;
    public int startedPieceCount=0;

    private void OnTriggerEnter(Collider other)
    {
        //startedPieceCount++;
    }
}
