using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speed = 180;
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
