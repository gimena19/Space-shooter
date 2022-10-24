using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] private float daño;
    [SerializeField] private string texto;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(texto))
        {
            other.GetComponent<Enemigo>().TomarDaño(daño);
            Destroy(gameObject);
        }
    }

}
