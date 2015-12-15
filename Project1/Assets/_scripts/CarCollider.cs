/*
Author: Maulik Patel
File : CarCollider.cs
Created Date: Dec 09,2015
Descriptopn: CarCollider controller script audio of the game
Laster Updated: Dec 13,2015
*/
using UnityEngine;
using System.Collections;

public class CarCollider : MonoBehaviour {
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider otherGameObject)
    {

		if (otherGameObject.tag == "Level1") {
			Application.LoadLevel ("Level1Done");
		}

		if (otherGameObject.tag == "Level2") {
			Application.LoadLevel ("Level2Done");
		}

		if (otherGameObject.tag == "Level3") {
			Application.LoadLevel ("Level3Done");
		
		}

		if (otherGameObject.tag == "police") {
			audio.Play();
		}
	}
}
