/*
Author: Maulik Patel and Sri Chatala
File : plane_collider.cs
Created Date: Dec 03,2015
Descriptopn: Controlling scenes
Laster Updated: Dec 13,2015
*/
using UnityEngine;
using System.Collections;

public class menucontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnStratButton(int sceneToChange) {
        Application.LoadLevel(sceneToChange);  
    }
    public void OnPlayGameButton(int sceneToChange)
    {
        Application.LoadLevel(sceneToChange);
    }
    public void OnBackButton(int sceneToChange)
    {
        Application.LoadLevel(sceneToChange);
    }
    public void OnLevel2Start(int level2)
    {
        Application.LoadLevel(level2);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
