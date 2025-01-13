using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOfCubes : MonoBehaviour
{
    public int cubeCount = 10; // Küp sayısı
    public float radius = 5f; // Çember yarıçapı

    void Start()
    {
        CreateCircleOfCubes();
    }

    void CreateCircleOfCubes()
    {
        // Çemberin merkezi
        Vector3 center = transform.position;

        // 360 dereceyi küp sayısına böleriz, böylece her küp bir açıya sahip olur
        float angleStep = 360f / cubeCount;

        for (int i = 0; i < cubeCount; i++)
        {
            // Küpün pozisyonunu hesaplayarak, çember etrafında yerleştiririz
            float angle = i * angleStep;
            float x = center.x + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            float z = center.z + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
            Vector3 cubePosition = new Vector3(z, center.y, x);

            // Küpü oluşturur ve ekleriz
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = cubePosition;
        }
    }
}