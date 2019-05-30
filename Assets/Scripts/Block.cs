using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    Points scoore;
    // Start is called before the first frame update
    void Start()
    {
        scoore = GameObject.Find("points").GetComponent<Points>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        scoore.number = scoore.number + 1;
    }
        // Update is called once per frame
        void Update()
    {
        transform.Translate(0f,-13f * Time.deltaTime,0f);
    }
}
