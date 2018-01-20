using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max; 
    int min;
    int guess;

	void Start () {
		StartGame();
	}


	
	void Update () {
		
	
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min=guess;
           NextGuess();

		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max=guess;
           	NextGuess();
        }else if (Input.GetKeyDown(KeyCode.Return)){
            print("I won the game.");
            StartGame();
        }

	}

	void StartGame(){
		 max = 1000;
	   	 min = 1;
	     guess=500;
		print("========================");
        print("Welcome to number wizard.");
        print("Pick a number in your head, but don't tell me.");
       
        print("The  number you can pick is from "+min+" to "+ max);
        print("Is the number higher or lower than "+ guess);
        print("Up arrow for higher, down for lower and return for equal");
		max=max+1;
	}
	void NextGuess(){
        guess=(max+min)/2;
		print("Higher or Lower than "+ guess);
		print("Up arrow for higher, down for lower and return for equal");
	}
}
 