using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public void play(){
	
		SceneManager.LoadScene ("Gameplay");
	}

	public void mainMenu(){
	
		SceneManager.LoadScene ("Main Menu");
	}
}
