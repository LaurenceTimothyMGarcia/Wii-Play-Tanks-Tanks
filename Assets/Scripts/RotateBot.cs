using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBot : MonoBehaviour
{
    public float rotationSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime * rotationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime * rotationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime * rotationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * rotationSpeed, Space.Self);
        }
    }
}
