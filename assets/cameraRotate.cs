using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.eulerAngles.z>-10.0)

        {
            
            transform.eulerAngles = new Vector3(
            transform.eulerAngles.x,
            transform.eulerAngles.y,
            transform.eulerAngles.z -1* Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A) && transform.eulerAngles.z<10.0)

        {
            
            transform.eulerAngles = new Vector3(
            transform.eulerAngles.x,
            transform.eulerAngles.y,
            transform.eulerAngles.z +1* Time.deltaTime);

        }
    }
}
