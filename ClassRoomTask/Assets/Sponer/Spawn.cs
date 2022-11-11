using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //���Ԍo�߂ƂƂ��ɃI�u�W�F�N�g���X�|�[�����������B

    //�f�X�g���C����Ȃ��̂ŏ������ǂ�ǂ�d���Ȃ��Ă����A�A
    //���̍����܂ōs����������悤�ɂ���B
    //�܂��APlayer���A�C�e�����擾����������B

    [SerializeField]
    public int _spownInterval = 1;
    private float _elapsed;

    [SerializeField]
    private GameObject _original = null;

    private void Update()
    {
        _elapsed += Time.deltaTime;
        
        if(_elapsed > _spownInterval)
        {
            _elapsed = 0;
            var item = Instantiate(_original);
            var rb = item.GetComponent<Rigidbody>();
            var x = Random.Range(-5 , 5);
            var y = Random.Range(3 , 10);
            var z = Random.Range(-5 , 5);

            rb.AddForce(x,y,z,ForceMode.Impulse);
            
        }

    }

}
