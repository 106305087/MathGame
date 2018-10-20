using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option3 : MonoBehaviour {

    public bool isCorrect;
    public GameObject core;
    public GameObject option1;
    public GameObject option2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        

        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
            int ans = core.GetComponent<GameController>().option;
            if (ans == 0)
            {
                option1.GetComponent<TextMesh>().color = new Color(255, 151, 0, 255);
            }
            else
            {
                option2.GetComponent<TextMesh>().color = new Color(255, 151, 0, 255);
            }
        }
    }
}
