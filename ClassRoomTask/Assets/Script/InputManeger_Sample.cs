using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputManeger_Sample : MonoBehaviour
{
    private void FixedUpdate()
    {
        //InputManager Ì¼z²
        var horizontal = Input.GetAxis("Horizontal");
        var vertical    = Input.GetAxis("Vertical");

        Debug.Log($"X²{horizontal}AY²{vertical}");

        transform.position = new Vector3(horizontal * 3 , vertical * 3 , 0.0f);
        

    }
}
