using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public string randomOperator;
    public int answer;
    public int option;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    // Use this for initialization
    void Start ()
    {
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);

        int operatorNumber = Random.Range(0, 3);
        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if (operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a - b;
        }
        else
        {
            randomOperator = "*";
            answer = a * b;
        }

        string questionText = a + " " + randomOperator + " " + b + " = ?";
        question.GetComponent<TextMesh>().text = questionText;

        int option = Random.Range(0, 3);
        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(1, 6)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(-1, -6)).ToString();
            option1.GetComponent<Option1>().isCorrect = true;
            option2.GetComponent<Option2>().isCorrect = false;
            option3.GetComponent<Option3>().isCorrect = false;

        }
        else if (option == 1)
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(1, 6)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(-1, -6)).ToString();
            option1.GetComponent<Option1>().isCorrect = false;
            option2.GetComponent<Option2>().isCorrect = true;
            option3.GetComponent<Option3>().isCorrect = false;
        }
        else
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(1, 6)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-1, -6)).ToString();
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option1>().isCorrect = false;
            option2.GetComponent<Option2>().isCorrect = false;
            option3.GetComponent<Option3>().isCorrect = true;
        }
        

    }
}
