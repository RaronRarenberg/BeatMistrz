using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Combo : MonoBehaviour
{
    public TextMeshProUGUI combo;
    public int number;
    public TextMeshProUGUI bestcombo;
    // Start is called before the first frame update
    void Start()
    {
        combo.text = number.ToString();
        bestcombo.text = PlayerPrefs.GetInt("BestCombo", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        combo.text = number.ToString();
        if (number > PlayerPrefs.GetInt("BestCombo", 0))
        {
            PlayerPrefs.SetInt("BestCombo", number);
        }
    }
}
