using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Item : MonoBehaviour
{
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.yellow;
    }
    private void FixedUpdate()
    {
        transform.Rotate(0.0f,1.0f,0.0f , Space.World);
    }
}
