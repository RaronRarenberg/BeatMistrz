using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnMouseOverButton : MonoBehaviour, IPointerEnterHandler
{
    AudioSource music ;
    void Start()
    {
        music = GetComponent<AudioSource>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        music.volume = PlayerPrefs.GetFloat("MasterVolume", 1);
        music.Play();

    }
}
