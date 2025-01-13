using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public GameObject referansalinacak;
    // Start is called before the first frame update
    void Start()
    {
        GameObject yeni = Instantiate(referansalinacak);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
