using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    float health;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = 1f;
        
        //healthBar.SetSize(0.4f);
    }

    // Update is called once per frame
    void Update()
    {
       // StartCoroutine(HealthDrain(0.1f));
    }
    public float GetHealth()
    {
        return health;
    }
    public void AddHealth(float amount)
    {
        if (health + amount > 1f)
        {
            health = 1f;
        }
        else
        {
            health = health + amount;
        }
    }
    public void SubtractHealth(float amount)
    {
        health = health - amount;
    }

    IEnumerator HealthDrain(float time)
    {
        if (health > 0f)
        {
            yield return new WaitForSeconds(time);
            health -= 0.001f;
            healthBar.SetSize(health);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
