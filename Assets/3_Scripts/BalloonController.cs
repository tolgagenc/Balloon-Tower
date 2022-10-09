using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class BalloonController : MonoBehaviour
{
    private Rigidbody rb;
    private RopeController ropeController;
    public Vector3 startPoint;
    public Transform endPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = Vector3.zero;
        rb.AddForce(new Vector3(Random.Range(-2,2), 30, Random.Range(-2,2)), ForceMode.Impulse);
        transform.DOScale(1, 3f);
    }
}
