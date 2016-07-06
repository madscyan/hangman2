using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;



public class Hangman : MonoBehaviour {

	public Player m_Player { get; private set; }
	public int m_numberOfMistakesAllowed {get; private set;}
	public string Word { get; private set; }
	public Outcome Outcome { get; private set; }

	// this is where im trying to store a random variable to choose a random word from the wordlist
	public System.Random random = new System.Random();


	[SerializeField] public TextAsset m_Text;
	[HideInInspector][SerializeField] public List<string> m_WordList;


	public void InitializeGame (Player player, int numberOfMistakesAllowed = 6){
		if (player == null){
			Debug.Log ("ma player is null");
		}
		if (m_numberOfMistakesAllowed < 0){
			Debug.Log ("number of mistakes must be non negative");
		}
		m_Player = player;

		// PROBLEM:  m_numberOfMistakesAllowed doesnt take the value passed from the method, nothing logs or print to the console.  Method doesnt function
		m_numberOfMistakesAllowed = numberOfMistakesAllowed;
		Outcome = Outcome.InProgress;
		Word = ChooseWord ();
		Debug.Log(numberOfMistakesAllowed);
		print ("hello");
	}

	public void InitializeGame () 
	{
		//TODO If no player is passed, create a default player
	}

	void Start (){

	if (m_Text != null)
		{	
			string content = m_Text.text;
			content = Regex.Replace(content, @"\s+","");
			string[]words = content.Split(',');
			m_WordList.AddRange (words);

			foreach (string value in m_WordList){
				print(value);
			}
		}
	}


	public void Guess (char letter){
	}

	// PROBLEM:  This is where im trying various stuff to choose a random word from teh wordlist
	private string ChooseWord (){
		//UnityEngine.Debug.Assert(m_WordList.Count > 0);
		//return m_WordList[random.Next(m_WordList.Count)];
		string chosenWord = m_WordList[Random.Range(0, m_WordList.Count)];
		return chosenWord;
		//return m_WordList[Random.Range(0, m_WordList.Count)];
		//UnityEngine.Debug.Log(chosenWord);
	}

}
