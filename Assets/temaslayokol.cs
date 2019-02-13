using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaslayokol : MonoBehaviour {
    public GameObject patlama;
    public GameObject playerpatlama;
    int score;
     GameObject    oyunkontrol;
     oyunkontrol kontrol;
    private void Start()
    {
        oyunkontrol = GameObject.FindGameObjectWithTag("Oyunkontrol"); //oyunkontrol objesine ulastı//scriptlerde bir companent
            
        kontrol = oyunkontrol.GetComponent<oyunkontrol>(); //oyun kontrol objesinin kontrol adında degiskeni
        //ilk basta oyunkontrolun oldugu objeye ulasmak lazım
       //objenin içindeki companente(scripti) ekledi
    }
    void OnTriggerEnter(Collider col)  // col bize carpan obje
    {
        if (col.tag != "sinir")
        {
            Destroy(col.gameObject);   //carpan kursun yok edilir
            Destroy(gameObject);      //kendini yok eder.
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.scorearttir(1);
         
           
            
        }
        if(col.tag=="Player")
        {
            Instantiate(playerpatlama, col.transform.position, col.transform.rotation);
        }
  
    }
    
}
