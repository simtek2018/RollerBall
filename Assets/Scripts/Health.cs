using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField] GameObject explosivePrefab;
    [SerializeField] int hitpoints = 10;

    // Update is called once per frame
    void Update() {
        if (hitpoints <= 0) {
            if (explosivePrefab) {
                Instantiate(explosivePrefab, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }

    public void ApplyDamage(int amount) {
        hitpoints = hitpoints - amount;
    }
}
