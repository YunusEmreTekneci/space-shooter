using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasyon : MonoBehaviour {
    Rigidbody fizik;
    public float hız;
	void Start () {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere*hız;
	}
	
	
	void Update () {
      
		
	}
}
