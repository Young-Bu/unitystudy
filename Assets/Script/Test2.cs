using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    int age = 24;
    float height = 172.2f;
    string myName = "������";
    bool canPlayGuitar = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���� �̸��� " + myName + "�Դϴ�.");
        Debug.Log("���� ���̴� " + age + "�Դϴ�.");
        Debug.Log("���� Ű�� " + height + "�Դϴ�.");
        Debug.Log("���� ��Ÿ ���� ���δ� " + canPlayGuitar + "�Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
