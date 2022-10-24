using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEnemy : MonoBehaviour
{
    [SerializeField] private float velocidadX = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, 0, 0);
        if ((transform.position.x < -30) || (transform.position.x > 30))
        {
            velocidadX = -velocidadX;
        }
    }
}
