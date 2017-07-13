using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteractions : MonoBehaviour {

	GameObject sword;
	GameObject dagger;

	// Use this for initialization
	void Start () {

		sword = GameObject.FindGameObjectWithTag ("sword");

		dagger = GameObject.FindGameObjectWithTag ("displayDagger");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
	
		if(col.tag == "blacksmith"){

			if(Input.GetKeyUp(KeyCode.F)){

				if (sword.activeSelf) {

					sword.SetActive (false);
					dagger.SetActive (true);
				} 

				else {

					dagger.SetActive (false);
					sword.SetActive (true);
				}

			}

		}

	}
}
