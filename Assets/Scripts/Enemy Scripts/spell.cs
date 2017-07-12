using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour {

    public GameObject player;
	private Vector3 targetPoint;

    private int speed = 7;
	float step;

	void Start () {

		step = speed * Time.deltaTime;
        targetPoint = player.transform.position;

		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetPoint, step, 0.0f);
		transform.rotation = Quaternion.LookRotation(newDir);
	}

	void Update () {

		transform.position = Vector3.MoveTowards(transform.position, targetPoint, step);

		if (transform.position == targetPoint) {
		
			Destroy (gameObject, 0.2f);
		}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			player.GetComponent<playerHealth>().damaged (gameObject.GetComponent<enemyAttack>().rangeDamage);
        }
    }
}
