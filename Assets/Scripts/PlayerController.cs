using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Rigidbody2D rig;
    private Vector2 moveinput;
    private bool isDead;
    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveinput = new Vector2(moveX, moveY);
    }

    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + moveinput * speed * Time.fixedDeltaTime);
    }


}
