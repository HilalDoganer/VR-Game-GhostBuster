using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newhi : MonoBehaviour
{
    Rigidbody rb;
    public int kuvvet;
    //public float moveSpeed = 5f; // Kamera hareket hýzý
    //public float rotationSpeed = 300f; // Kamera döndürme hýzý

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject mermi = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            rb = mermi.AddComponent<Rigidbody>();
            
            rb.AddForce(transform.forward * kuvvet, ForceMode.Force);
            mermi.transform.position = gameObject.transform.position;
            mermi.transform.rotation = gameObject.transform.rotation;

            //mermi.transform.rotation = Camera.main.transform.rotation;



        }



        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        //float scrollInput = Input.GetAxis("Mouse ScrollWheel"); // Mouse tekerleði giriþini al

        //// Kameranýn ileri ve geri hareketi
        //Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        //transform.position += transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime;

        //// Kameranýn yatay dönüþü
        //float rotationInput = Input.GetAxis("Mouse X");
        //transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);

        //// Kameranýn dikey dönüþü (mouse tekerleði ile)
        //transform.Rotate(Vector3.right, -scrollInput * rotationSpeed * Time.deltaTime);


    }
}
