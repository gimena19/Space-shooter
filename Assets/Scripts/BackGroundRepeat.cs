using  System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{

    private float spriteWidth;
    
    private void Awake() { 
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -32)
        {
            ResetPosition();
        }
         
    }

    private void ResetPosition()
    {
        transform.Translate(new Vector3(0f, 2*32, 0f));
    }
}
 