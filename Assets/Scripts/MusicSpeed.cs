﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSpeed : MonoBehaviour
{
    AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (music.pitch == 1.0f)
            {
                music.pitch = 0.5f;
            }
            else
                music.pitch = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (music.pitch == 1.0f)
            {
                music.pitch = 8.0f;
            }
            else
                music.pitch = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (music.pitch == 1.0f)
            {
                music.pitch = 10.0f;
            }
            else
                music.pitch = 1.0f;
        }
    }
}