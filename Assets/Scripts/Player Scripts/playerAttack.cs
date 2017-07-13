﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerAttack : MonoBehaviour {

	public GameObject sword;
	public GameObject dagger;
	public GameObject display_Dagger;
	public GameObject poolManager;

	float timer;

	// Use this for initialization
	void Start () {

		//sword = GameObject.FindGameObjectWithTag ("sword");

		//dagger = GameObject.FindGameObjectWithTag ("dagger");

		//display_Dagger = GameObject.FindGameObjectWithTag ("displayDagger");

		timer = 0;

	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (Application.platform == RuntimePlatform.Android) {

			//Hay que hacer que el if detecte que el joystick esta siendo usado

			/*
			if (CrossPlatformInputManager) {

				if(sword.activeSelf == true){

					//Activar cosas de la espada
				}

				if (display_Dagger.activeSelf == true) {

					poolManager.GetComponent<poolManager> ().reuseObject (dagger, transform.position + Vector3.up * 1/2, transform.rotation);
				}
			}
				*/
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
		
			if(sword.activeSelf == true){

				//Activar cosas de la espada
			}

			if (display_Dagger.activeSelf == true) {

				if (timer >= 0.3) {
					poolManager.GetComponent<poolManager> ().reuseObject (dagger, transform.position + Vector3.up * 1 / 2, transform.rotation /*+ Quaternion.AngleAxis(180, Vector3.up)*/);
					timer = 0;
				}
			}
		}

		if (timer > 60)
			timer = 1;
	}
}
