using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Hole : MonoBehaviour
{
    //どのボールを吸い寄せるかタグでｋ指定
    public string targetTag;

    //OnTriggerStayはオブジェクト同士の重なり合いのときに、発生する
    void OnTriggerStay(Collider other)
    {
        //コライダに触れているオブジェクトのRigidBodyコンポーネントを取得
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        Debug.Log("In");
        //ボールがどの方向にあるかを計算
        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        //タグに応じてぼーるにちからをくわえる　
        if (other.gameObject.tag == targetTag)
        {
            //中心地点でボールを止めるため速度を減速
            r.velocity *= 0.9f;
            r.AddForce(direction * -20.0f, ForceMode.Acceleration);
        }
        else
        {
            r.AddForce(direction * 80.0f, ForceMode.Acceleration);
        }

    }

}
