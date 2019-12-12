using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class FPSMove : MonoBehaviour
{

    public GameObject cam, camPoint, head;//se crea instancia publica para usar una variable de otra clase

    public float velocity = 7f;

    void Update()
    {
        float XRot = Input.GetAxisRaw("Mouse X")*3;
        float YRot = Input.GetAxisRaw("Mouse Y")*3;
        transform.Rotate(new Vector3(0, XRot, 0));
        head.transform.Rotate(new Vector3(YRot*-1, 0, 0));
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * velocity * Time.deltaTime;
        }
    }
}
