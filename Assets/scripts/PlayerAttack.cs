using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay; // 공격 딜레이 시간
    public float attackTime; // 공격 딜레이

    public float attackDamage; // 공격력
    public float playerHp; // 생명력

    public GameObject attackPrefab; //발사체
    GameObject attackObjPoint; //발사체 위치
    public float attackSpeed; //발사체 속도

    Transform playerPos; //플레이어 위치

    private void Start()
    {
        //자식중에 발사체 Obj 가져오기 
        attackObjPoint = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        // 시간이 흐른다
        attackDelay += Time.deltaTime;
        if (attackDelay > attackTime)
        {
            Fire();
            attackDelay = 0;
        }
    }
    void Fire()
    {// 발사체 만들고 쏘고
        if(attackPrefab !=null)
        {
            // Instantiate 복제한다 (발사체 위치지정)
            GameObject newAttackPre = Instantiate(attackPrefab, attackObjPoint.transform.position, attackObjPoint.transform.rotation);
            // AddForce 미는 힘 
            newAttackPre.GetComponent<Rigidbody>().AddForce(-attackPrefab.transform.forward* attackSpeed, ForceMode.Impulse);

        }
    }
}