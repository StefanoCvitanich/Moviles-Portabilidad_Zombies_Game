using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    public int health;

	public GameObject poolManager;

	int randomNumber = -1;

	// Use this for initialization
	void Start () {

		poolManager = GameObject.FindGameObjectWithTag ("poolManager");
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

			if(randomNumber == 2)
				poolManager.GetComponent<poolManager> ().reuseObject (poolManager.GetComponent<poolManager> ().healthItem, transform.position, transform.rotation);
		}
    }

    public void healed(int hld)
    {
        health += hld;
    }
}
