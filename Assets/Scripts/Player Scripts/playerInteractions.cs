using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerInteractions : MonoBehaviour {

	GameObject sword;
	GameObject dagger;

	bool daggerEnabled;

	public int killedSorcerers = 0;

	UnityEvent enableDagger;

	// Use this for initialization
	void Start () {

		sword = GameObject.FindGameObjectWithTag ("sword");

		dagger = GameObject.FindGameObjectWithTag ("displayDagger");
		dagger.SetActive (false);

		if (enableDagger == null)
			enableDagger = new UnityEvent ();

		enableDagger.AddListener (unlockDagger);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (killedSorcerers >= 5)
			enableDagger.Invoke ();
	}

	void OnTriggerStay(Collider col){
	
		if(col.tag == "armory"){
			Debug.Log ("entraste a la armeria");
			if(Input.GetKeyUp(KeyCode.F)){

				if (daggerEnabled) {
					
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

	public void unlockDagger(){

		daggerEnabled = true;
	}
}
