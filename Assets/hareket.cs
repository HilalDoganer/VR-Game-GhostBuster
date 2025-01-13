using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float minSpeed = 0f;
    public float maxSpeed = 0.5f;
    public float minRotationSpeed = 30f;
    public float maxRotationSpeed = 100f;

    private Rigidbody rb;
    private float rotationSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 movementDirection = new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-50f, 50f)).normalized;

        float movementSpeed = Random.Range(minSpeed, maxSpeed);
        rb.velocity = movementDirection * movementSpeed;

        // Rastgele dönüþ hýzý ve yönü belirle
        rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
        if (Random.Range(0, 2) == 0)
            rotationSpeed *= -1; // Rastgele dönüþ yönü seç
    }

    void FixedUpdate()
    {
        // Objeyi x ve z düzlemlerinde rastgele döndür
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

        // Eðer obje sýnýrlarýn dýþýna çýkarsa, tekrar sýnýrlar içine al
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, -30f,30f);
        newPosition.z = Mathf.Clamp(newPosition.z, -30f,30f);
        newPosition.y = Mathf.Clamp(newPosition.y, 0f, 10f);
        transform.position = newPosition;
    }
}
