using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    //How many times can you go left and right
    int step_counter = 0; 
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HIT");
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            if(step_counter != 0)
            { 
                transform.Translate(-3f, 0, 0);
                step_counter -= 1;
            }
        }
        else if(Input.GetKeyDown("right"))
        {
            if (step_counter != 3)
            {
                transform.Translate(3, 0, 0);
                step_counter += 1;
            }
            
        }

    }
}
