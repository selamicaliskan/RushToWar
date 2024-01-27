using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetMoveUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude<100){
                GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.Impulse);
                //GetComponent<Rigidbody>().velocity=Vector3.zero;
            }
    }
}
