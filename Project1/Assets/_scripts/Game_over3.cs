/*
Author: Maulik Patel
File : Game_over3.cs
Created Date: Dec 10,2015
Descriptopn: Game_over3 controller script controll skip from this level
Laster Updated: Dec 13,2015
*/
using UnityEngine;
using System.Collections;

public class Game_over3 : MonoBehaviour {
	private string[] cheatCode;
	private int index;
	void Start () {
		// Code is "idkfa", user needs to input this in the right order
		cheatCode = new string[] { "l", "e", "v", "e", "l","3" };
		index = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// Check if any key is pressed
		if (Input.anyKeyDown) {
			// Check if the next key in the code is pressed
			if (Input.GetKeyDown (cheatCode [index])) {
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
			
			Application.LoadLevel ("Level3Done");
			Debug.Log ("Cheat code successful");
		}
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.relativeVelocity.magnitude > 1)
		{
			Application.LoadLevel("Game Over 3");
		}
		
	}
}
