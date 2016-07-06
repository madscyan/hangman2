using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program : MonoBehaviour {

		public Player player;
		public Hangman game;

		void Start (){

		player = Instantiate(Resources.Load<Player>("Prefabs/Player"));
		player.InitializePlayer();
		Debug.Log (player.Name);

		game = Instantiate(Resources.Load<Hangman>("Prefabs/Hangman Game"));
		game.InitializeGame(player, 7);

		game.Guess ('a');

	}

}
