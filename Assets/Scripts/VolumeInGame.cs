using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeInGame : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioListener.volume != 1.0f)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                AudioListener.volume += 0.5f;
            }
        }
        if (AudioListener.volume != 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                AudioListener.volume -= 0.5f;
            }
        }
    }
}