using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputSample : MonoBehaviour
{
    private void FixedUpdate()
    {
        //�P���Ȓ��ړ��̓f�o�C�X���Ď�����V�X�e��
        //���t���[����������Ă����Ԃ��ǂ���

        transform.position *= 0;

        if (Input.GetKey(KeyCode.UpArrow))//��
        {
            transform.position = Vector3.up * 5;
        }

        if (Input.GetKey(KeyCode.DownArrow))//��
        {
            transform.position = Vector3.down * 5;
        }

        if(Input.GetKey(KeyCode.RightArrow))//�E
        {
            transform.position = Vector3.right * 5;
        }
        if(Input.GetKey(KeyCode.LeftArrow))//��
        {
            transform.position = Vector3.left * 5;
        }
    }

}
