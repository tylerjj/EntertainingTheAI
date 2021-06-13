using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int initial_min;
    int initial_max;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    } 

    void StartGame()
    {

        if (min > max)
        {
            // Edge Case: If min is greater than max, swap max and min values. 
            int temp = max;
            max = min;
            min = temp;
        }

        initial_min = min;
        initial_max = max;

        NextGuess();
    }


    public void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        if (guess != initial_max && (min != max) && (min < max))
        {
            min = guess + 1;
        } else 
        {
            min = guess;
        }
        NextGuess();
    }

    public void OnPressLower()
    {
        if (guess != initial_min && (min != max) && (min < max))
        {
            max = guess - 1;
        } else
        {
            max = guess;
        }
        NextGuess();
    }
}
