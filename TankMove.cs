using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankMove : MonoBehaviour
{   
    bool fail=false;
    //float maxSpeed=60;
    bool start = false;

    public int hiz=10;
    public static float tankXCoordinate=99999999999;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tankXCoordinate=transform.position.x;
        //Debug.Log(tankXCoordinate);
        if (Input.GetKey(KeyCode.W) || start == true)
        {
            start = true;
            GetComponent<Rigidbody>().velocity = Vector3.left * hiz * 10;
            
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameMenu");
        }




        if (Input.GetKey(KeyCode.D) && transform.position.z < 11.2)

        {
            transform.Translate(10 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.z > -11.2)

        {
            transform.Translate(-10 * Time.deltaTime, 0, 0);
        }




    }

    private void OnCollisionEnter(Collision collision){
        if (collision.transform.tag=="Engel"){
            Invoke("restart",1f);
            fail=true;
        }
    }



    private void restart(){
        SceneManager.LoadScene("RetryMenu");
        fail=false;
    }
}
