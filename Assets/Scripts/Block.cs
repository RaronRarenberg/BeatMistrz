using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    Points scoore;
    Combo coombo;
    // Start is called before the first frame update
    void Start()
    {
        scoore = GameObject.Find("points").GetComponent<Points>();
        coombo = GameObject.Find("points").GetComponent<Combo>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player" || other.gameObject.name == "player2" || other.gameObject.name == "player3" || other.gameObject.name == "player4")
        {
            scoore.number = scoore.number + 1;
            coombo.number = coombo.number + 1;
        }
        else if (other.name == "combo-reset-trigger")
        {
            coombo.number = 0;
        }
    }
        // Update is called once per frame
        void Update()
    {
        transform.Translate(0f,-13f * Time.deltaTime,0f);
    }
}
