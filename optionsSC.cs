using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
public class optionsSC : MonoBehaviour
{

    public TMP_Dropdown graphicsDropdown;
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer NAudioMixer;

    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value,true);
        Debug.Log("kalite değişti");
    }

    public void ChangeMasterValume()
    {
        NAudioMixer.SetFloat("MasterVol",masterVol.value);
    }
    public void ChangeMusicValume()
    {
        NAudioMixer.SetFloat("MusicVol",musicVol.value);
    }
    public void ChangeSFXValume()
    {
        NAudioMixer.SetFloat("SFXVol",sfxVol.value);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
