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

    //Function to set rules for the start of the game
    public void Start()
    {
        CalculateGuess();
        winText.SetActive(false);
    }

    //Function to show the guess on screen
    public void Update()
    {
        uiGuess.text = "Guess: " + guess.ToString();
    }

    //Function to calculate a guess
    private void CalculateGuess()
    {
        guess = (min + max)/2;
    }

    //Function for the Higher - Button
    public void HigherButton()
    {
        min = guess + 1;
        CalculateGuess();
    }

    //Function for the Lower - Button
    public void LowerButton()
    {
        max = guess - 1;
        CalculateGuess();
    }

    //Function for the Correct - Button
    public void CorrectButton()
    {
        winText.SetActive(true);
        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
    }
}
