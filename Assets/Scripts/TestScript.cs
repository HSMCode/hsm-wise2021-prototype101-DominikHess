using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public int firstNumber = 1;
    public int secondNumber = 4;
    public int thirdNumber = 6;
    public int fourthNumber = 8;
    public int fifthNumber = 10;
    public float result;
    public string resultText = "Result: ";

    // Start is called before the first frame update
    void Start()
    {
        result = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) / 3f;
        Debug.Log(resultText + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
