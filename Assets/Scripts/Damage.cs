using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int amountOfDamage = 10;

    private void OnCollisionEnter(Collision collision) {
        Health health = collision.gameObject.GetComponent<Health>();
        
        if (health == null) {
            return;
        } else {
            health.ApplyDamage(amountOfDamage);
        }
    }

}
