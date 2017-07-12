using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour {

    public int meleDamage;
    public int rangeDamage;
	private float timer = 0;

    GameObject player;
	GameObject poolManager;
    public GameObject healTraget;
    public GameObject spell;
    
    // Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
		poolManager = GameObject.FindGameObjectWithTag ("poolManager");
    }
	
	// Update is called once per frame
	void Update () {

		if (gameObject.tag == "sorcerer") {

			timer += Time.deltaTime;
			rangeAttack ();
		}
        
    }

    private void rangeAttack()
    {
        if (timer >= 3)
        {
			if (Vector3.Distance (transform.position, player.transform.position) <= 8) 
			{           
				poolManager.GetComponent<poolManager>().reuseObject(spell, gameObject.transform.position + Vector3.up, gameObject.transform.rotation);
				timer = 0;
			}	
        } 
    }

    private void heal()
    {
        healTraget.GetComponent<enemyHealth>().healed(3); //falta determinar cómo se elije el healTarget
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			collision.gameObject.GetComponent<playerHealth>().damaged (meleDamage);

        } 
    }
}
