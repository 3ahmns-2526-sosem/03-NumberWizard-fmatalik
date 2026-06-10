using UnityEngine;
using TMPro;

public class Calculate : MonoBehaviour
{
    public int max = 100;
    public int min = 1;
    public int guess;

    public TextMeshProUGUI uiGuess;

    public void Start()
    {
        CalculateGuess();
    }

    public void Update()
    {
        uiGuess.text = "Guess: " + guess.ToString();
    }

    void CalculateGuess()
    {
        guess = Random.Range(min, max);
    }

    public void HigherButton()
    {
        min = guess + 1;
        CalculateGuess();
    }

    public void LowerButton()
    {
        max = guess - 1;
        CalculateGuess();
    }
}
