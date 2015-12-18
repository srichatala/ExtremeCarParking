/*Author: Maulik Patel and Sri Chatala
File : plane_collider.cs
Created Date: Dec 017,2015
Descriptopn: Game play scoring
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoring : MonoBehaviour {

	public Text StackColLabel;
	public int  StackColValue = 0;
	public Text StackLeftLabel;
	public int StackLeftValue = 3;

	public GameObject element1;
	public GameObject element2;
	public GameObject element3;
	public GameObject parking;

	// Use this for initialization
	void Start () {
		this._SetScore();
		parking.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherGameObject)
	{
		if (otherGameObject.tag == "element1") {
			Destroy (element1);

			this.StackColValue += 1;
			this.StackLeftValue -= 1;
		}

			if (otherGameObject.tag == "element2") {
			Destroy (element2);
				
			this.StackColValue += 1;
			this.StackLeftValue -= 1;

		}
				if (otherGameObject.tag == "element3") {
			Destroy (element3);
					
			this.StackColValue += 1;
			this.StackLeftValue -= 1;

		}			
		this._SetScore();	
		if(StackColValue==3){
			parking.SetActive(true);
		}


	}

	private void _SetScore() {
		this.StackColLabel.text = "Stacks Collected:  " + this.StackColValue;
		this.StackLeftLabel.text = "Stacks Left: " + this.StackLeftValue;
	}

}
