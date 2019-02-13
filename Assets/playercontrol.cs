using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol: MonoBehaviour {
    Rigidbody fizik;
    public float karakterhız;
    float ateszamani = 0;
    /* public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
   */
    public GameObject kursun;
    public Transform kursunnerdencıksın;
    public float nekadarsüredeatesedilsin;
    AudioSource audıo;
    void Start () {
        fizik = GetComponent<Rigidbody>();
        audıo = GetComponent<AudioSource>();
    }

  void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > ateszamani)

         {   ateszamani = Time.time + nekadarsüredeatesedilsin;                            
            audıo.Play();
            Instantiate(kursun, kursunnerdencıksın.position, Quaternion.identity);
            }
    }

    void FixedUpdate () {
        float hareket1=Input.GetAxis("Horizontal");
        float hareket2=Input.GetAxis("Vertical");
        Vector3 hareket = new Vector3(hareket1, 0, hareket2);

        fizik.velocity = hareket*karakterhız;

        /*fizik.position = new Vector3(
            Mathf.Clamp(fizik.position.x, minX, maxX), 
            0       ,
            Mathf.Clamp(fizik.position.z, minZ, maxZ)

            );
       */
    }
}
