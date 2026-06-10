using UnityEngine;
using TMPro;

public class Calculate : MonoBehaviour
{
    public int max = 100;
    public int min = 0;
    public int guess;

    public TextMeshProUGUI uiGuess;

    public void Start()
    {
        CalculateGuess();
    }

    public void Update()
    {
        uiGuess.text = guess.ToString();
    }

    void CalculateGuess()
    {
        guess = Random.Range(min, max);
    }
}
