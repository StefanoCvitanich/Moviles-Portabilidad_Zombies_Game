using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour {

	public int meleDamage = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "zombie" || collision.gameObject.tag == "sorcerer") {

			collision.gameObject.GetComponent<enemyHealth> ().damaged (meleDamage);
		}
	}
}
