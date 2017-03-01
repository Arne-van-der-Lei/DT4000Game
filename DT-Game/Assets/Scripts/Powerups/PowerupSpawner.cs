using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour {

    public GameObject[] Powerups;
    public GameObject[] powerupsLocations;
    public float TimeBeforeSpawn = 15f;
    // Use this for initialization
    void Start () {
        StartCoroutine(spawnRandom());
    }

    //spawns a random powerup at a random defined location each 15 seconds
    IEnumerator spawnRandom() {
        while (true)
        {
            yield return new WaitForSeconds(TimeBeforeSpawn);
            GameObject NewPowerup = Instantiate(Powerups[Random.Range(0, Powerups.Length)], Vector3.zero, Quaternion.identity);
            GameObject spawner = powerupsLocations[Random.Range(0, powerupsLocations.Length)];
            NewPowerup.transform.position = spawner.transform.position;
            spawner.GetComponent<PowerUpSpawnPoint>().spawnObject(NewPowerup);
        }
    }
}
