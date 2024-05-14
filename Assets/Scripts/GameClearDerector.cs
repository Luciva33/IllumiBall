using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDerector : MonoBehaviour
{
    public GameObject ClearMsg;
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;

    //簡易的なＵＩシステム　1秒間に６０回
    // void OnGUI()
    // {
    //     GUI.matrix = Matrix4x4.Scale(Vector3.one * 2);
    //     //全てのボールが入ったら、ラベル表示
    //     // if (holeRed.IsHolding() && holeBlue.IsHolding() && holeGreen.IsHolding())

    //     //プロパティ
    //     if (holeRed.IsHolding && holeBlue.IsHolding && holeGreen.IsHolding)
    //     {
    //         GUI.Label(new Rect(50, 50, 100, 30), "GAME CLEAR!!");
    //     }
    // }

    /*
    h1.setHp(h1.getHp()+10)
   javaのsettergetterはめんどくさい 
    */

    void Update()
    {
        if (holeRed.IsHolding && holeBlue.IsHolding && holeGreen.IsHolding)
        {
            ClearMsg.SetActive(true);
        }
        else
        {
            ClearMsg.SetActive(false);

        }
    }


}
