using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //���Ԍo�߂ƂƂ��ɃI�u�W�F�N�g���X�|�[�����������B

    //�f�X�g���C����Ȃ��̂ŏ������ǂ�ǂ�d���Ȃ��Ă����A�A
    //���̍����܂ōs����������悤�ɂ���B

    public int _spownInterval;
    private float _elapsed;
    

    private void Update()
    {
        _elapsed += Time.deltaTime;
        
        if(_elapsed > _spownInterval)
        {
            _elapsed = 0;

            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cube.AddComponent<Rigidbody>();
        }

    }

}
