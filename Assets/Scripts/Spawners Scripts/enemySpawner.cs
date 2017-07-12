using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    private float timer;
    public GameObject zombie;
    public GameObject sorcerer;
    public GameObject player;
    public GameObject poolManager;

    // Use this for initialization
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 5)
        {
            spawnZombie();

            spawnSorcerer();

            timer = 0;
        }
    }

    private void spawnZombie()
    {
        poolManager.GetComponent<poolManager>().reuseObject(zombie, transform.position, transform.rotation);
    }

    private void spawnSorcerer()
    {
        poolManager.GetComponent<poolManager>().reuseObject(sorcerer, transform.position, transform.rotation);
    }
}