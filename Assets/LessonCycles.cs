using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonCycles : MonoBehaviour
{
    [SerializeField] private InputField _userInput;
    [SerializeField] private Text _answer;
    private int[] _numbers;

    private void Start()
    {
        _numbers = new int[5] { 5 ,2, 8, 7, 1 };
    }

    public void SearchNumber()
    {
        if (int.TryParse(_userInput.text, out int userNumber ))
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (_numbers[i] == userNumber)
                {
                    _answer.text = userNumber + "найдено";
                    break;
                }
                else
                {
                    _answer.text = "такого числа нет";

                }
            }
        }
        
    }

}
