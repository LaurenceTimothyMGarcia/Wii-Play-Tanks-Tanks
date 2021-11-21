using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBottomController : MonoBehaviour
{
    //Variables
    public float movementSpeed;
    public float rotationSpeed;
    public GameObject mine;

    //functions
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        /*if ((horizontalInput < 0.5 && horizontalInput > -0.5) && (verticalInput < 0.5 && verticalInput > -0.5))
        {
            Vector3 noMovement = new Vector3(0,0,0);
            transform.Translate(noMovement, Space.Self);
        }
        else
        {
            //need to find right audio file first
            //FindObjectOfType<AudioManager>().Play("TankMovement");
        }*/

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * movementSpeed * Time.deltaTime, Space.World);

        //makes the rotation based on current direction
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(mine, transform.position, transform.rotation);
        }
    }
}
