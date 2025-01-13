using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public int sphereCount = 10; // Küre sayýsý
    public GameObject ornek;
    public float minX = -50f;
    public float maxX = 50f;
    public float minY = 0f;
    public float maxY = 50f;
    public float minZ = -50f;
    public float maxZ = 50f;

    void Start()
    {
        // Rastgele küreleri oluþtur
        for (int i = 0; i < sphereCount; i++)
        {
            // Rastgele konum oluþtur
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            float randomZ = Random.Range(minZ, maxZ);
            Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

            // Rastgele renk oluþtur
            Color randomColor = new Color(Random.value, Random.value, Random.value);

            // Küreyi oluþtur
            //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            GameObject sphere = Instantiate(ornek);

            sphere.transform.position = randomPosition;
            sphere.GetComponent<Renderer>().material.color = randomColor;

            //// materyal için;
            // MeshRender rnd = go GetComponent<MeshRenderer>();
            // rnd.material.color = Random.ColorHSV();

            // Kürenin boyutunu rastgele ayarla
            float randomScale = Random.Range(0.5f, 2f);
            sphere.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
        }
    }
}