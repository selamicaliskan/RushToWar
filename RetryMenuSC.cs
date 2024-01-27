using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RetryMenuSC : MonoBehaviour
{
    // Start is called before the first frame update

    public static int bulletScore=0;
    public TextMeshProUGUI skor;

    void Update()
    {
        if(BulletSC.win)
        {
            bulletScore = bulletCollector.bullet;
            skor.text="KAZANDINIZ SKOR: " + bulletScore.ToString();
        }else{
            bulletScore = bulletCollector.bullet;
            skor.text="SKOR: " + bulletScore.ToString();
        }
        
    }
    public void reStart()
    {
        SceneManager.LoadScene("Game");
        bulletCollector.bullet=0;
    }

    public void CallMainMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Player Has Quit");
    }
}
