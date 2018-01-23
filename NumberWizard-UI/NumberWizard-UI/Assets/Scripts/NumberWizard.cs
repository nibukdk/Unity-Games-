using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max; 
    int min;
    int guess;
    int maxGuess=15;
    public Text text;

	void Start () {
		StartGame();
	}


	public void GuessHigher(){
			min=guess;
           NextGuess();
	}
	public void GuessLower(){
			max=guess;
           NextGuess();
	}

	void StartGame(){
		 max = 10000;
	   	 min = 1;
	     NextGuess();
	
	}
	void NextGuess(){
        guess=Random.Range(min,max+1);
        text.text=guess.ToString();
        maxGuess=maxGuess-1;
        if(maxGuess<=0){
        	Application.LoadLevel("Win");
        }
    }
}
 