using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sınırlayıcı : MonoBehaviour {

	

        void OnTriggerExit(Collider col)
        {
            Destroy(col.gameObject);
        }

		
    
}
