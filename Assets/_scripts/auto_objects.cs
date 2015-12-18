/*
Author: Maulik Patel and Sri Chatala
File : auto_object.cs
Created Date: Dec 18,2015
Descriptopn: Generate automatic police cars during game play
*/
using UnityEngine;
using System.Collections;

public class auto_objects : MonoBehaviour {


	public GameObject car1;
	public GameObject collider1;
	public GameObject car2;
	public GameObject collider2;
	public GameObject car3;
	public GameObject collider3;
	public GameObject car4;
	public GameObject collider4;
	public GameObject car5;
	public GameObject collider5;
	// Use this for initialization
	void Start () {
		car1.SetActive(false);
		car2.SetActive(false);
		car3.SetActive(false);
		car4.SetActive(false);
		car5.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherGameObject)
	{
		if (otherGameObject.tag == "collider1") {
			Destroy (collider1);
			car1.SetActive(true);
		}

		if (otherGameObject.tag == "collider2") {
			Destroy (collider2);
			car2.SetActive(true);
		}

		if (otherGameObject.tag == "collider3") {
			Destroy (collider3);
			car3.SetActive(true);
		}

		if (otherGameObject.tag == "collider4") {
			Destroy (collider4);
			car4.SetActive(true);
		}

		if (otherGameObject.tag == "collider5") {
			Destroy (collider5);
			car5.SetActive(true);
		}
	}
}
