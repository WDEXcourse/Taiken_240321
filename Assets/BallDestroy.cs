using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    // 弾が何かに当たったら

    void OnCollisionEnter(Collision collision){
        Destroy(this.gameObject);//弾自身を破壊する
    }
}
