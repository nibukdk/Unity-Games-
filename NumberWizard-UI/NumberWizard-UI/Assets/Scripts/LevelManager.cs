using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Requesting for next level to load.");
		Application.LoadLevel(name);

		}

	public void QuitRequest(){
		Debug.Log("Requesting for quitting game.");
		Application.Quit();

	}
}
