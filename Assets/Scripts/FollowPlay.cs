using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlay : MonoBehaviour
{
    //声明一个Transform属性，不要忘了在编辑器里拖拽赋值
    public Transform player;
    //声明一个偏移
    public Vector3 offset ;
    // Update is called once per frame
    void Update()
    {
        //transform.position定义对象的位置
        transform.position = player.position + offset;
        


    }
}
