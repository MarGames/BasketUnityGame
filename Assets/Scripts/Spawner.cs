using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    bool onetime = false;
    public GameObject spawnObjects;
    private float timer = 0.0f;
    Vector3 random;
    private float spawnTime = 5f;
    private float spawnDelay = 3f;
    private void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        random = new Vector3(0.5f, 8f, Random.Range(-3f, 4f));
        if (timer > 20f)
        {
            CancelInvoke("Spawn");
            if (!onetime)
            {
                spawnDelay = 3f;
                spawnTime = 1f;
                InvokeRepeating("Spawn2", spawnDelay, spawnTime);
                onetime = true;
            }
        }
    }
    void Spawn()
    {
        Instantiate(spawnObjects, random, Quaternion.identity);
    }
    void Spawn2()
    {
        Instantiate(spawnObjects, random, Quaternion.identity);
    }
}
