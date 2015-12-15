/*
Author: Maulik Patel
File : Cheatcode2.cs
Created Date: Dec 10,2015
Descriptopn: Cheatcode2 controller script controll skip from this level
Laster Updated: Dec 13,2015
*/
using UnityEngine;
using System.Collections;

public class Cheatcode2 : MonoBehaviour {
	
	private string[] cheatCode;
	private int index;
	// Use this for initialization
	void Start () {
		// Code is "idkfa", user needs to input this in the right order
		cheatCode = new string[] { "p", "a", "s", "s", "2" };
		index = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// Check if any key is pressed
		if (Input.anyKeyDown) {
			// Check if the next key in the code is pressed
			if (Input.GetKeyDown(cheatCode[index])) {
				// Add 1 to index to check the next key in the code
				index++;
			}
			// Wrong key entered, we reset code typing
			else {
				index = 0;    
			}
			
		}
		
		// If index reaches the length of the cheatCode string, 
		// the entire code was correctly entered
		if (index == cheatCode.Length) {
			// Cheat code successfully inputted!
			// Unlock crazy cheat code stuff
			
			Application.LoadLevel("Level2Done");
			Debug.Log("Cheat code successful");
		}
	}
	
}
