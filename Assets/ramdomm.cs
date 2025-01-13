using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramdomm : MonoBehaviour
{

    public int num;
    public GameObject[] ornek;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < num; i++) 
        {
            GameObject go = Instantiate(ornek[Random.Range(0,ornek.Length-1)]);
            go.transform.position = new Vector3(Random.Range(-50,50),Random.Range(10,30),Random.Range(-50,50));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
