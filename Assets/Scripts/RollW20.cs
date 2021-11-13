using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollW20 : MonoBehaviour
{
    public int result;

    public int luckyNumber1 = 1;
    public int luckyNumber2 = 13;
    public int luckyNumber3 = 20;

    // Start is called before the first frame update
    void Start()
    {
         RollDice();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice(); 
        }
    }

    // Generates a random number (int) between 1 and 20
    void RollDice()
    {
        result = Random.Range(1, 21);
        CheckLuckyNumber();
    }

    // Checks for lucky numbers and prints successful rolls on the debug console
    void CheckLuckyNumber()
    {
        if (result == luckyNumber1 || result == luckyNumber2 || result == luckyNumber3)
        {
            Debug.Log("Awesome! You rolled a " + result + "!");
        }
    }
}