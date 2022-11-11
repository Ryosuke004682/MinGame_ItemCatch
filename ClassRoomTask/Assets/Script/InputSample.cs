using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputSample : MonoBehaviour
{
    private void FixedUpdate()
    {
        //単純な直接入力デバイスを監視するシステム
        //毎フレームが押されている状態かどうか

        transform.position *= 0;

        if (Input.GetKey(KeyCode.UpArrow))//上
        {
            transform.position = Vector3.up * 5;
        }

        if (Input.GetKey(KeyCode.DownArrow))//下
        {
            transform.position = Vector3.down * 5;
        }

        if(Input.GetKey(KeyCode.RightArrow))//右
        {
            transform.position = Vector3.right * 5;
        }
        if(Input.GetKey(KeyCode.LeftArrow))//左
        {
            transform.position = Vector3.left * 5;
        }
    }

}
