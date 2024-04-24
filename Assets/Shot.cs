using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private Vector3 playarPosition;//プレイヤーの位置
    private float x;　　　　　　　　　//計算用x
    private float y;　　　　　　　　　//計算用y
    private float z;　　　　　　　　　//計算用z
    private Vector3 ballNewPosition;//ボールを発射する位置
    public GameObject prefabBall;　　//プレファブ用で使うゲームオブジェクト　
    private GameObject cloneBall;　　//クローンした後のゲームオブジェクト
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //もしスペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //プレイヤーの座標を取得する
            playarPosition = this.gameObject.transform.position;
            //プレイヤーの座標を変数x、y、zにそれぞれわける
            x = playarPosition.x;
            y = playarPosition.y;
            z = playarPosition.z;
            //プレイヤーの左表をもとに、クローンとして作るボールの座標を計算する
            ballNewPosition = new Vector3(x,y + 1.0f, z + 1.0f);
            //cloneBallに、クローンしたボールをセットする
            cloneBall = GameObject.Instantiate(prefabBall,ballNewPosition,Quaternion.identity);
            //cloneBallを発射する
            cloneBall.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        }
    }
    
}
