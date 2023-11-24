using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.Experimental.GraphView;
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

    GameObject newAttackPre; // Instantiate 복제한다 (발사체 위치지정)

    private void Start()
    {
        //자식중에 발사체 Obj 가져오기
        // 이거 인덱스 번호로 가져오면 나중에 까먹고 오브젝트 추가허면???
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
        if(newAttackPre != null)
        {
            newAttackPre.transform.Translate(Vector3.forward * 0.05f);
        }
    }
    void Fire()
    {// 발사체 만들고 쏘고
        if (attackPrefab != null)
        {
            // Instantiate 복제한다 (발사체 위치지정)
            newAttackPre = Instantiate(attackPrefab, attackObjPoint.transform.position, attackObjPoint.transform.rotation);
        }
    }
}