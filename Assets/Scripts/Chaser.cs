using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    private Transform target;
    [SerializeField] float speed = 4f;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        if (player != null) {
            target = player.transform;
        }
    }

    void Update()
    {
        if (target != null) {
            transform.LookAt(target);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
