using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    Points scoore;
    Combo coombo;
    Health hp;
    // Start is called before the first frame update
    void Start()
    {
        scoore = GameObject.Find("points").GetComponent<Points>();
        coombo = GameObject.Find("points").GetComponent<Combo>();
        hp = GameObject.Find("Health").GetComponent<Health>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player" || other.gameObject.name == "player2" || other.gameObject.name == "player3" || other.gameObject.name == "player4")
        {
            scoore.number = scoore.number + 1;
            coombo.number = coombo.number + 1;
            if (hp.GetHealth() < 1f)
            {
                hp.AddHealth(0.1f);
            }
        }
        else if (other.name == "combo-reset-trigger")
        {
            coombo.number = 0;
            hp.SubtractHealth(0.1f);
        }
        
    }
        // Update is called once per frame
        void Update()
    {
        transform.Translate(0f,-13f * Time.deltaTime,0f);
    }
}
