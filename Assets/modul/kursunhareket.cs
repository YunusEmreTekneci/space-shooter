using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursunhareket : MonoBehaviour
{

    Rigidbody fizik;
    public float hız;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * hız;            
    }


    void Update()
    {

    }
}