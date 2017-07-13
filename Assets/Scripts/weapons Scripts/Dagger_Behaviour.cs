using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger_Behaviour : MonoBehaviour {

	public int daggerDamage = 1;

	float timer;

	// Use this for initialization
	void Start () {

		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		gameObject.transform.position += (gameObject.transform.forward) * 1/2;

		if (timer > 5) {
			gameObject.GetComponent<poolObject> ().destroy ();
			timer = 0;  //Es necesaria esta linea de codigo? O cuando esta activa nuevamente el Start() lo pone en 0?
		}

	}

	void OnTriggerEnter(Collider col){
	
		if (col.tag == "zombie" || col.tag == "sorcerer" || col.tag == "giant") {
		
			col.GetComponent<enemyHealth> ().damaged (daggerDamage);

			gameObject.GetComponent<poolObject> ().destroy ();
		}

	}
}
