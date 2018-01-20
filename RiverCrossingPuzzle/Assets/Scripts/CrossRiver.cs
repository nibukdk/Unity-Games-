using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrossRiver : MonoBehaviour {
	public Text text;
	// Use this for initialization
	private enum MovesList{ Goat, Wolf, Cabbage, Empty, textDisplay, firstLevel,firstLevel_2, secondLevel,thirdLevelWithCabbage, thirdLevelWithWolf,fourthLevelWithCabbage,fourthLevelWithGoat,fourthLevelWithWolf, gameOver };
	 private MovesList moves;
	void Start () {
		moves=MovesList.textDisplay;
	
		
	}


	
	// Update is called once per frame
	void Update () {
		if(moves==MovesList.textDisplay)		{ start_text();	}
		else if(moves==MovesList.firstLevel)	{ game_start();	}
		else if(moves==MovesList.firstLevel_2)	{ first_level_2();	}
		else if (moves==MovesList.secondLevel)	{ second_level();}
		else if (moves==MovesList.thirdLevelWithCabbage)	{ third_level_cabbage();}
		else if (moves==MovesList.thirdLevelWithWolf)	{ third_level_wolf();}
		else if(moves==MovesList.gameOver)		{ game_over();}

	}

	void start_text(){
		text.text="\t\t\t\t\tWelcome User!!\n\n"+
					" A man once had to travel with a wolf, a goat and a cabbage. He had to take good care of them, "+
					"since the wolf would like to taste a.piece of goat if he would get the chance, while the goat appeared "+
					"to long for a tasty cabbage. After some traveling, he suddenly stood before a river. This river could only"+
					" be crossed using the small boat laying nearby at a shore. The boat was only good enough to take himself and "+
					"one of his loads across the river. The other two subjects/objects he had to leave on their own. How must the "+
					"man row across the river back and forth, to take himself as well as his luggage safe to the other side of the river, "+
					"without having one eating another?\n"+
					"Now press P to play";

		if(Input.GetKeyDown(KeyCode.P))		{ moves=MovesList.firstLevel;}

	}

	//First Level of the game
	void game_start(){
		text.text="Ok! So, now that you know the situation what will you take with you first to cross the river?\n\n"+
					"Press G for Goat, W for Wolf and C for Cabbage";

		if(Input.GetKeyDown(KeyCode.G))		{moves=MovesList.secondLevel;}			
		else if(Input.GetKeyDown(KeyCode.W))		{moves=MovesList.gameOver;}			
		else if(Input.GetKeyDown(KeyCode.C))		{moves=MovesList.gameOver;}			
	}

	//Game Over 
	void game_over(){
		text.text="Oh no!! You could not save all your belonging.\n"+
					"Game Over\n\n"+
					"Press P to play again.";
			if(Input.GetKeyDown(KeyCode.P))		{ moves=MovesList.firstLevel;}

	}
	//Reaching cross the river with goat first stage 
	void second_level(){
		text.text="Ok Now that you brought goat to the other shore.\n"+
			"Press R to return to other bank where there are Cabbage and Wolf";

		if(Input.GetKeyDown(KeyCode.R))		{ moves=MovesList.firstLevel_2;}
	}

	//Next Animal Pick
	void first_level_2(){
		text.text="Here we are again at the bank of river.\n"+
					"Now there are Wolf and Cabbage at this end and Goat at another end.\n"+
					"What will you do?\n\n"+
					"Press W for Wolf and C for Cabbage";

			if(Input.GetKeyDown(KeyCode.C))		{moves=MovesList.thirdLevelWithCabbage;}
			else if(Input.GetKeyDown(KeyCode.W))		{moves=MovesList.thirdLevelWithWolf;}	
	}
	//Taking Cabbage for second Transport

	void third_level_cabbage(){
			text.text="Allrighty! You brought Cabbage with you but goat is right there.\n"+
						" If you leave Cabbage with Goat, there wont be any Cabbage when you return.\n"+
						"You can also take back one of them to first end to correct the error.\n\n"+
						"Press G for Goat and C for Cabbage.";

			if(Input.GetKeyDown(KeyCode.C))		{moves=MovesList.fourthLevelWithCabbage;}
		else if(Input.GetKeyDown(KeyCode.G))		{moves=MovesList.fourthLevelWithGoat;}	
	}
	//Taking Wolf for second Tranport 
	void third_level_wolf(){
		text.text="Allrighty! You brought Wolf with you but goat is right there.\n"+
						" If you leave those two together, there wont be any Goat when you return.\n"+
						"You can also take back one of them to first end to correct the error.\n\n"+
						"Press G for Goat and W for Wolf.";

			if(Input.GetKeyDown(KeyCode.W))		{moves=MovesList.fourthLevelWithWolf;}
		else if(Input.GetKeyDown(KeyCode.G))		{moves=MovesList.fourthLevelWithGoat;}	

	}

}
