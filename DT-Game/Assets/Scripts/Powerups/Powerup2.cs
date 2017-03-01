using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup2 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Powerup 2");
            Destroy(gameObject);
        }
    }
}
