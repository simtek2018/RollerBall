using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField] GameObject objectToSpawn;
    [SerializeField] float spawnTime = 2f;
    private float maxPos = 14.0f;

    private void Start() {
        StartCoroutine("SpawnCoroutine");
    }

    IEnumerator SpawnCoroutine() { 
        yield return new WaitForSeconds(spawnTime);
        while (true) {
            SpawnItem();
            yield return new WaitForSeconds(spawnTime);
        }
    }

    void SpawnItem() {
        float xPos = Random.Range(-maxPos, maxPos);
        float zPos = Random.Range(-maxPos, maxPos);
        Vector3 newPos = new Vector3(xPos, transform.position.y, zPos);
        Instantiate(objectToSpawn, newPos, gameObject.transform.rotation);
                
    }
}
