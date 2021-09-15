using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public Vector3 rotateVector = new Vector3(-1, 0, 0);
    public float speed = 50;

    private void Update()
    {
        transform.Rotate(rotateVector * speed * Time.deltaTime);
    }
}
