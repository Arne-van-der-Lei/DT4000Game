using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour {

    GameObject[] _PowerupSpawns;
    List<GameObject> _ValidPowerupSpawns = new List<GameObject>();
    public Transform[] powerUps;
    int _RandomIndex;
    Transform _NewPowerup;

    // Use this for initialization
    void Start () {
        _PowerupSpawns = GameObject.FindGameObjectsWithTag("PowerupSpawn");
        StartCoroutine(spawnRandom());
    }

    IEnumerator spawnRandom() {
        while (true)
        {
            yield return new WaitForSeconds(15);
            _ValidPowerupSpawns.Clear();
            for (int i = 0; i < _PowerupSpawns.Length; i++)
            {
                if (_PowerupSpawns[i].transform.childCount <= 0)
                {
                    _ValidPowerupSpawns.Add(_PowerupSpawns[i]);
                }
            }
            if (_ValidPowerupSpawns.Count != 0)
            {
                _NewPowerup = Instantiate(powerUps[UnityEngine.Random.Range(0, powerUps.Length)], Vector3.zero, Quaternion.identity);
                _NewPowerup.transform.parent = _ValidPowerupSpawns[UnityEngine.Random.Range(0, _ValidPowerupSpawns.Count)].transform;
                _NewPowerup.transform.localPosition = Vector3.zero;
            }
        }
    }
}
