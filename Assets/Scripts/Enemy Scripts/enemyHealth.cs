using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    public int health;
	Vector3 spawnPos;

	public GameObject poolManager;

	int randomNumber = -1;

	// Use this for initialization
	void Start () {

		poolManager = GameObject.FindGameObjectWithTag ("poolManager");

		spawnPos = new Vector3 (0, 0.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void damaged(int dmg)
    {
        health -= dmg;

		if (health <= 0) {
			
			gameObject.GetComponent<poolObject> ().destroy ();

			randomNumber = Random.Range (1, 4);

			//Debug.Log (randomNumber);

			if(randomNumber == 2){

				spawnPos += transform.position;
				poolManager.GetComponent<poolManager> ().reuseObject (poolManager.GetComponent<poolManager> ().healthItem, spawnPos, transform.rotation);
			}
		}
    }

    public void healed(int hld)
    {
        health += hld;
    }
}
