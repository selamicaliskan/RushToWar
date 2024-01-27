using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletSC : MonoBehaviour
{
    public float life =10;
    public static bool win=false;

    void Awake()
    {
        gameObject.transform.eulerAngles = new Vector3(
        gameObject.transform.eulerAngles.x+90,
        gameObject.transform.eulerAngles.y,
        gameObject.transform.eulerAngles.z);
        Destroy(gameObject,life);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="Engel")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if(collision.transform.tag=="kargo")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            win=true;
            SceneManager.LoadScene("RetryMenu");
            
        }
    }
    
}
