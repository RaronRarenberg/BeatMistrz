using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolume : MonoBehaviour
{
    
   
    public void SetVolume(float vol)
    {

        PlayerPrefs.SetFloat("MasterVolume", vol);
    }
}
