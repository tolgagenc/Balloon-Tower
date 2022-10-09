using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    public Vector3 StartPoint;
    public Transform EndPoint;
    private LineRenderer line;

    private void Start()
    {
        line = GetComponent<LineRenderer>();

        line.startWidth = 0.1f;
        line.endWidth = 0;
        
        line.useWorldSpace = true;
        line.positionCount = 2;
        line.SetPosition(0, StartPoint);
        line.SetPosition(1, EndPoint.position);
    }

    private void Update()
    {
        line.SetPosition(1, EndPoint.position);
    }
}
