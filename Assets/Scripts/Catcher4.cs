using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher4 : MonoBehaviour
{
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
        if (Input.GetKeyDown("k"))
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.collider.enabled = true;
        }
        else
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.collider.enabled = false;
    }
}
