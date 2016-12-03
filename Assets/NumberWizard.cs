using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	
	public int maxGuessAllowed = 10;
	public Text text;
	
	void Start () {
		StartGame();
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessLower (){
		max = guess;
		NextGuess();
	}
	
	public void GuessHigher (){
		min = guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessAllowed--;
		if (maxGuessAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}
