using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public string Name { get; private set; }

	public void InitializePlayer (string name){
		if (name == null){
			throw new System.ArgumentNullException("name");
			}
		Name = name;
		}

	public void InitializePlayer(){
		Name = "sdf";
	}
}
