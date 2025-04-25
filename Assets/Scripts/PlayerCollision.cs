using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //声明一个Movement属性
    public Movement move;

    //OnCollisionEnter 是 Unity 提供的一个特殊方法，用于处理碰撞事件。Collision 是一个结构体，包含了关于碰撞的详细信息，例如碰撞点、碰撞力、碰撞的游戏对象等。
    void OnCollisionEnter(Collision collisionInfo)
    {
        //如果碰撞对象的标签为Obstacle，则停下来
        if(collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
