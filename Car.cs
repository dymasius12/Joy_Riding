using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    /**
     * written by dymasius12: Mon, 16th May 2022:
     * *Implemented car moving forward
    */

    [SerializeField] private float speed =10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
