using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text score;
    public int number;
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        score.text = number.ToString();
        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
        score.text = number.ToString();
        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
        }
    }
}
