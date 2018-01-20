using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	private enum States{cell, mirror, lock_0, sheets_0, cell_mirror, lock_1, sheets_1, freedom };
	private States myState;

	// Use this for initialization
	void Start () {
		myState=States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if( myState==States.cell)				{set_state();}
		else if( myState==States.sheets_0)		{set_state_sheets_0();}
		else if( myState==States.sheets_0)		{set_state_sheets_1();} 
		else if(myState==States.lock_0)			{set_state_lock_0();}
		else if(myState==States.lock_1)			{set_state_lock_1();}
		else if(myState==States.mirror)			{set_state_mirror();}
		else if(myState==States.cell_mirror)	{set_state_cell_mirror();}
		else if(myState==States.freedom)		{set_state_freedom();}

	}

	void set_state(){
		text.text="You are a prisoner inside a cell. The only items inside your cell are sheets on"+
					" a bed, a mirror on the wall (used to open the lock), and a locked door(from outside) which "+
					"can only be opened with the aid of the mirror.\n\n"+
					"Press S to view sheets, M to view Mirror and L to view Lock";
	        
		if (Input.GetKeyDown(KeyCode.S))		{myState=States.sheets_0;} 
		else if (Input.GetKeyDown(KeyCode.L))	{myState=States.lock_0;} 
		else if (Input.GetKeyDown(KeyCode.M))	{myState=States.mirror;} 

	}
	//Going to see sheets 
	void set_state_sheets_0(){
		text.text="DAMNNN.... you have been sleeping in dirtiest sheets I have ever seen.\n"+
					"Time to change it.\n\n"+
					"Press R to return to roaming your cell.";
	        
		if (Input.GetKeyDown(KeyCode.R))		{myState=States.cell;} 
		
	}
	//Looking state sheets
	void set_state_sheets_1(){
		text.text="Holding mirror in your hand doesnot makes sheets any better.\n"+
					"Instead try other fruitfull stuff.\n\n"+
					"Press R to return to roaming your cell .";
	        
		if (Input.GetKeyDown(KeyCode.R))		{myState=States.cell_mirror;} 
		
	}
	//Viewing the state of lock

	void set_state_lock_0(){
		text.text="Ok Mr.obvious door is locked!! \n"+
			"The lock is one of those button locks.\n\n"+
				"Press R to return to roaming your cell.";
	        
		if (Input.GetKeyDown(KeyCode.R))		{myState=States.cell;} 
		
	}
	//Try to open the lock
	void set_state_lock_1(){
		text.text="Ok so you have the mirror.\n"+
					" Now, you carefully put your hand across the mirror and than look at the lock. \n"+
					"After that try to crack the number code of the lock.\n\n\n"+
					"Hey!!! you opened the lock now you can be free!\n\n"+
				"Press R to return to roaming your cell or O to open the cell";
	        
		if (Input.GetKeyDown(KeyCode.R))		{myState=States.cell;} 
		else if (Input.GetKeyDown(KeyCode.O))	{myState=States.freedom;} 
		
	}

	//Deciding about  Mirror 

	void set_state_mirror(){
		text.text="The dirty mirror seems to be loose on the wall.\n\n"+
				"Press R to return to roaming your cell or T to take mirror in your hands";
	        
		if (Input.GetKeyDown(KeyCode.R))		{myState=States.cell;} 
		else if (Input.GetKeyDown(KeyCode.T))	{myState=States.cell_mirror;} 

	}

	//Taking mirror in your hand
	void set_state_cell_mirror(){
		text.text="Why don't you try to look the lock of the door instead of your face.\n\n"+
				"Press R to return to roaming your cell or L to take mirror in your hands.";
	        
		if (Input.GetKeyDown(KeyCode.R))		{myState=States.cell;} 
		else if (Input.GetKeyDown(KeyCode.L))	{myState=States.lock_1;} 

	}

	//Opening the lock
	void set_state_freedom(){
		text.text="You are free now.\n\n"+
				"Press P play again.";
	        
		if (Input.GetKeyDown(KeyCode.P))		{myState=States.cell;}



	}
	//*************End of Cell_Scene******************

}
