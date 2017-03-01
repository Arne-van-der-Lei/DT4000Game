using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup3 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Powerup 3");
            Destroy(gameObject);
        }
    }
}
