using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    private int value = 1;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            if (GameManager.gm != null) {
                GameManager.gm.Loot(value);

                Destroy(gameObject);
            }
        }
    }
}
