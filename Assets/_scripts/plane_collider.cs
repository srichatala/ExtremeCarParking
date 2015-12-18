/*
Author: Maulik Patel and Sri Chatala
File : plane_collider.cs
Created Date: Dec 09,2015
Descriptopn: Player dies when he gets of the road strip in level 3
Laster Updated: Dec 13,2015
*/
using UnityEngine;
using System.Collections;

public class plane_collider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherGameObject)
	{
		
		if (otherGameObject.tag == "plane") {
			Application.LoadLevel ("Game Over 3");
		}
	}
}
