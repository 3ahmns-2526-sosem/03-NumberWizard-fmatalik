using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public int max = 100;
    public int min = 1;
    public int guess;

    public TextMeshProUGUI uiGuess;
    public GameObject winText;

    public Button higherButton;
    public Button lowerButton;
    public Button correctButton;

    public void Start()
    {
        CalculateGuess();
        winText.SetActive(false);
    }

    public void Update()
    {
        uiGuess.text = "Guess: " + guess.ToString();
    }

    void CalculateGuess()
    {
        guess = (min + max)/2;
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

    public void CorrectButton()
    {
        winText.SetActive(true);
        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
    }
}
