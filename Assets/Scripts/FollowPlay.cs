using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlay : MonoBehaviour
{
    //����һ��Transform���ԣ���Ҫ�����ڱ༭������ק��ֵ
    public Transform player;
    //����һ��ƫ��
    public Vector3 offset ;
    // Update is called once per frame
    void Update()
    {
        //transform.position��������λ��
        transform.position = player.position + offset;
        


    }
}
