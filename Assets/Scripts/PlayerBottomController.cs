using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBottomController : MonoBehaviour
{
    //Variables
    public float movementSpeed;
    public GameObject camera;
    //public RigidBody rb;

    //functions
    void Update()
    {
        //Player facing mouse
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        //float characterAngle = Vector3.Angle(Vector3.forward, transform.forward);
        //Quaternion rotation = Quaternion.AngleAxis(characterAngle, Vector3.up);

        //not good because axis gets changed locally
        /*if(playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            //Vector3 relativePos = Vector3.magnitude - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            //Quaternion targetRotation = Quaternion.LookRotation(relativePos, Vector3.up);

            targetRotation.x = 0;
            targetRotation.z = 0;

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 7f * Time.deltaTime);
            //transform.rotation = targetRotation;
        }*/

        //PlayerMovement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            //transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime * movementSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            //transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime * movementSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
            //transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime * movementSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
            //transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime * movementSpeed, Space.Self);
        }
    }
}
