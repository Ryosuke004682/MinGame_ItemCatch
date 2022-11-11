using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [Header("Playerの移動パラメーター")]
    public float _speed = 1.0f;

    Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal") * _speed;
        var vertical = Input.GetAxis("Vertical") * _speed;

        _rb.AddForce(horizontal,0,vertical);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
    }
}
