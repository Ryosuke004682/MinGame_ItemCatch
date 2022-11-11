using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //時間経過とともにオブジェクトをスポーンさせたい。

    //デストロイされないので処理がどんどん重くなっていく、、
    //一定の高さまで行ったら消すようにする。
    //また、Playerがアイテムを取得したら消す。

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
