using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class droneMove : MonoBehaviour
{
    // Start is called before the first frame update 45225.18   49935.1
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TankMove.tankXCoordinate<45350.0)
        {
            GetComponent<Rigidbody>().velocity = Vector3.left * 6 * 10;
        }
    }
}
