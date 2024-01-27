using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuSC : MonoBehaviour
{
    
    public void Play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        bulletCollector.bullet=0;
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Player Has Quit");
    }


}
