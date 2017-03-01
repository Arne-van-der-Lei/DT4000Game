using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePowerUp : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Triggered(other.gameObject);
            Destroy(gameObject);
        }
    }

    public abstract void Triggered(GameObject player);
}
