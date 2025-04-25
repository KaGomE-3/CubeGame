using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //����һ��Movement����
    public Movement move;

    //OnCollisionEnter �� Unity �ṩ��һ�����ⷽ�������ڴ�����ײ�¼���Collision ��һ���ṹ�壬�����˹�����ײ����ϸ��Ϣ��������ײ�㡢��ײ������ײ����Ϸ����ȡ�
    void OnCollisionEnter(Collision collisionInfo)
    {
        //�����ײ����ı�ǩΪObstacle����ͣ����
        if(collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
