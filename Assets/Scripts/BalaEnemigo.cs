using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float da?o;
    private void Update()
    {


        transform.Translate(Vector2.down * velocidad * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("nave"))
        {
            other.GetComponent<Enemigo>().TomarDa?o(da?o);
            Destroy(gameObject);
        }
    }



}
