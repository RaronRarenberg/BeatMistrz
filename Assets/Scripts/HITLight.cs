using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HITLight : MonoBehaviour
{
    public GameObject farleft;
    public GameObject midleft;
    public GameObject midright;
    public GameObject farright;
    // Start is called before the first frame update
    void Start()
    {
        farleft = GameObject.Find("green-light");
        farleft.GetComponent<Light>().enabled = false;

        midleft = GameObject.Find("orange-light");
        midleft.GetComponent<Light>().enabled = false;

        midright = GameObject.Find("magenta-light");
        midright.GetComponent<Light>().enabled = false;

        farright = GameObject.Find("cyan-light");
        farright.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("HIT1"))
        {
            StartCoroutine(ShowAndHide(0.1f, farleft));
        }
        else if (Input.GetButtonDown("HIT2"))
        {
            StartCoroutine(ShowAndHide(0.1f, midleft));
        }
        else if (Input.GetButtonDown("HIT3"))
        {
            StartCoroutine(ShowAndHide(0.1f, midright));
        }
        else if (Input.GetButtonDown("HIT4"))
        {
            StartCoroutine(ShowAndHide(0.1f, farright));
        }
    }
    IEnumerator ShowAndHide(float time, GameObject who)
    {
        who.GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(time);
        who.GetComponent<Light>().enabled = false;
    }
}
