using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuvvet : MonoBehaviour
{
    Rigidbody rb;
    public int kuvvett;
    public AudioClip silahses;
    public GameObject mermi2;
  
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))

        {

            GameObject mermi = Instantiate(mermi2);

            rb = mermi.AddComponent<Rigidbody>();
            rb.AddForce(transform.forward * kuvvett, ForceMode.Force);
            mermi.transform.position = gameObject.transform.position;
            mermi.transform.rotation = gameObject.transform.rotation;   

            AudioSource ses = mermi.AddComponent<AudioSource>();
            ses.clip = silahses;
            ses.Play();
        }

    }
}
