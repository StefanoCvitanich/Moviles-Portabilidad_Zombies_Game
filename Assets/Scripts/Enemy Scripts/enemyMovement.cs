using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

    public GameObject player;
    GameObject enemySpawner;

    public float speed;
	private float step;
    private bool sorcerer;
    private float rotSpeed = 1;

	private Vector3 targetDir;
	private Vector3 newDir;
    private Vector3 biDimensionalPlayerPosition;


    void Awake()
    {
        enemySpawner = GameObject.FindGameObjectWithTag("enemySpawner");

        player = enemySpawner.GetComponent<enemySpawner>().player;
    }

    void Start () {

        if (gameObject.tag == "sorcerer")
            sorcerer = true;
    }

    void Update () {

        if (!sorcerer)
        {
            targetDir.x = (player.transform.position - transform.position).x;
            targetDir.y = transform.position.y;
            targetDir.z = (player.transform.position - transform.position).z;
            targetDir.Normalize();
            step = speed * Time.deltaTime;

            newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);

            transform.rotation = Quaternion.LookRotation(newDir);

            biDimensionalPlayerPosition.x = player.transform.position.x;
            biDimensionalPlayerPosition.y = transform.position.y;
            biDimensionalPlayerPosition.z = player.transform.position.z;

            transform.position = Vector3.MoveTowards(transform.position, biDimensionalPlayerPosition, step);
        }
        else if (sorcerer)
        {
            targetDir.x = (player.transform.position - transform.position).x;
            targetDir.y = transform.position.y;
            targetDir.z = (player.transform.position - transform.position).z;
            targetDir.Normalize();

			newDir = Vector3.RotateTowards(transform.forward, targetDir, rotSpeed * Time.deltaTime, 0.0f);

            biDimensionalPlayerPosition.x = player.transform.position.x;
            biDimensionalPlayerPosition.y = transform.position.y;
            biDimensionalPlayerPosition.z = player.transform.position.z;

            transform.rotation = Quaternion.LookRotation(newDir);

			if (Vector3.Distance(transform.position, player.transform.position) >= 5)
            {
                step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, biDimensionalPlayerPosition, step);
            }
        }
    }
}
