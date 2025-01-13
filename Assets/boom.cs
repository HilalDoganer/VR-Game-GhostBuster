using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    public AudioClip carpýsma;
    public GameObject asd;
    public GameObject patlamaPrefab; // Patlama efektini içeren prefab

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("mermi1"))

        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            // Patlama efektini oluþtur
        GameObject patlama = Instantiate(patlamaPrefab, transform.position, Quaternion.identity);

            // Patlama sesini çal
            AudioSource ses = asd.AddComponent<AudioSource>();
            ses.clip = carpýsma;
            ses.Play();
        }
    }
    // Start ve Update metodlarý gibi kullanýlmayan metodlar kaldýrýldý.
}