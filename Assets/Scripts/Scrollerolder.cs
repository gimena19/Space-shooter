using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollerolder : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
