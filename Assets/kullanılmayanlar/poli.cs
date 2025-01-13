using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poli : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger exit");
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger stay");
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colis enter");
        Destroy(go);
        go2.SetActive(false);


    }

    public void OnCollisionExit(Collision collision) 
    {
        Debug.Log("colis exit");
    }

    public void OnCollisionStay(Collision collision)
    {
        Debug.Log("colis stay");
    }


}
