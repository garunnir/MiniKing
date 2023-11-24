using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay; // ���� ������ �ð�
    public float attackTime; // ���� ������

    public float attackDamage; // ���ݷ�
    public float playerHp; // �����

    public GameObject attackPrefab; //�߻�ü
    GameObject attackObjPoint; //�߻�ü ��ġ
    public float attackSpeed; //�߻�ü �ӵ�

    GameObject newAttackPre; // Instantiate �����Ѵ� (�߻�ü ��ġ����)

    private void Start()
    {
        //�ڽ��߿� �߻�ü Obj ��������
        // �̰� �ε��� ��ȣ�� �������� ���߿� ��԰� ������Ʈ �߰����???
        attackObjPoint = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        // �ð��� �帥��
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
    {// �߻�ü ����� ���
        if (attackPrefab != null)
        {
            // Instantiate �����Ѵ� (�߻�ü ��ġ����)
            newAttackPre = Instantiate(attackPrefab, attackObjPoint.transform.position, attackObjPoint.transform.rotation);
        }
    }
}