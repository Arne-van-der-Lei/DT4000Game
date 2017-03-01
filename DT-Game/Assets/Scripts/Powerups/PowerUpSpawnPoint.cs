using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnPoint : MonoBehaviour {

    GameObject _Object;

    public void spawnObject(GameObject obj)
    {
        if(_Object == null)
        {
            _Object = obj;
        }else
        {
            Destroy(obj);
        }
    }
}
