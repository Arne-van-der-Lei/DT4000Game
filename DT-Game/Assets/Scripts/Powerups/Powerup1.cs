using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup1 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Powerup 1");
            Destroy(gameObject);
        }
    }
}
