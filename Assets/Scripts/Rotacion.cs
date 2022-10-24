using UnityEngine;
using System.Collections;

public class Rotacion : MonoBehaviour
{
    public int speed; // the speed of rotation

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.down);
    }
}