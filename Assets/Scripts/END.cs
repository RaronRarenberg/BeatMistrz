using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -13f * Time.deltaTime, 0f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("tak");
        if (other.name == "combo-reset-trigger")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Debug.Log("bardzo tak");
        }
    }
}
