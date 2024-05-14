using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    //重力加速度
    const float Gravity = 9.18f;

    //重力の適用具合
    [SerializeField] //privateでも、インスペクターで数値をいじれる
    float gravityScale = 3.0f;

    void Update()
    {
        //重力の初期化
        Vector3 vector = new Vector3();

        //スマートフォン用加速度センサー
        if (Application.isMobilePlatform)
        {
            vector.x = Input.acceleration.x;
            vector.y = Input.acceleration.y;
            vector.z = Input.acceleration.z;
        }
        else
        {

            //キーの入力を検知し、ベクトルを認定
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");

            //高さ方向の判定はキーのZとする
            if (Input.GetKey("z"))
            {
                vector.y = 1.0f;
            }
            else
            {
                vector.y = -1.0f;
            }
        }
        //シーンの重力を入力ベクトルの方向に合わせて変化させる
        //normalizedをしておかないと、キーの同時押しのとき、重力が余計にかかる
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
