using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // ������ �߻�!!
    private void Start()
    {
        Debug.Log("Hi");
    }

    private void OnTriggerEnter(Collider other)
    {
        // �߻�ü ���� ����
        Destroy(gameObject);
        Debug.Log("Hi1");
    }
}
