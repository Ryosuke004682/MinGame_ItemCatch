using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //時間経過とともにオブジェクトをスポーンさせたい。

    //デストロイされないので処理がどんどん重くなっていく、、
    //一定の高さまで行ったら消すようにする。

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
