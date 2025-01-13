using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hocakup : MonoBehaviour
{
    public float kupsayisi;
    Vector3 yaricap = new Vector3(5, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < kupsayisi; i++)
        {
            GameObject kup = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 rot = new Vector3(0, 0, (360 / kupsayisi) * i);

            Quaternion q = Quaternion.Euler(rot);
            Debug.Log("buraya kadar calisiyorp");
            Vector3 pos = q * yaricap;
            kup.transform.position = pos;
            Debug.Log("program sonu");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}