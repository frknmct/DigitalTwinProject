using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public int finishedPieceCount=0;
    public GameObject write;

    private void OnTriggerEnter(Collider other)
    {
        finishedPieceCount++;
        if (other.gameObject.tag == "LastPiece")
        {
            write.gameObject.GetComponent<Write>().SendPieceInfo(1,finishedPieceCount);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<ProductMovement>().speed = 0.0001f;
    }
}
