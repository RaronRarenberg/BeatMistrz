using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public GameObject farleft;
    public GameObject midleft;
    public GameObject midright;
    public GameObject farright;
    // Start is called before the first frame update
    void Start()
    {
        farleft = GameObject.Find("player");
        farleft.GetComponent<Renderer>().enabled = false;
        farleft.GetComponent<BoxCollider2D>().enabled = false;

        midleft = GameObject.Find("player2");
        midleft.GetComponent<Renderer>().enabled = false;
        midleft.GetComponent<BoxCollider2D>().enabled = false;

        midright = GameObject.Find("player3");
        midright.GetComponent<Renderer>().enabled = false;
        midright.GetComponent<BoxCollider2D>().enabled = false;

        farright = GameObject.Find("player4");
        farright.GetComponent<Renderer>().enabled = false;
        farright.GetComponent<BoxCollider2D>().enabled = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HIT");
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("HIT1"))
        {
            StartCoroutine(ShowAndHide(0.1f,farleft));
        }
         if (Input.GetButtonDown("HIT2"))
        {
            StartCoroutine(ShowAndHide(0.1f, midleft));
        }
        if (Input.GetButtonDown("HIT3"))
        {
            StartCoroutine(ShowAndHide(0.1f, midright));
        }
        if (Input.GetButtonDown("HIT4"))
        {
            StartCoroutine(ShowAndHide(0.1f, farright));
        }

    }
    IEnumerator ShowAndHide(float time,GameObject who)
    {
        who.GetComponent<Renderer>().enabled = true;
        who.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(time);
        who.GetComponent<Renderer>().enabled = false;
        who.GetComponent<BoxCollider2D>().enabled = false;
    }
}
