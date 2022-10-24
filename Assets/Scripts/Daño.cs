using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] private float daño;
    [SerializeField] private GameObject efectoMuerte;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("nave"))
        {
            other.GetComponent<Enemigo>().TomarDaño(daño);
            Destroy(gameObject);
            Muerte();
        }
    }
    private void Muerte()
    {
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
