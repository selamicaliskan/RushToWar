using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletCollector : MonoBehaviour
{

    public static int bullet=0;
    public AudioSource source;
    public AudioClip clip;
    public TextMeshProUGUI bulletCounter;
    

    private void OnTriggerEnter(Collider other){
        if (other.transform.tag=="bullet"){
            source.PlayOneShot(clip);
            bullet++;
            bulletCounter.text=bullet.ToString();
            //Debug.Log(bullet);   
            Destroy(other.gameObject);
        }
        
    }
}
