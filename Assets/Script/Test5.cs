using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i<= 10; i++)
        {
            Debug.Log("10 ���� ���" + i + "Ÿ!");
        }

        int fireTime = 5;
        while(fireTime > 0)
        {
            Debug.Log("���� �پ� ���� 5�� �Ծ���!(���� �ð� " + fireTime + "�� ����");
            fireTime--;
        }
        int[] numArr = new int[3];
        numArr[0] = 1;
        numArr[1] = 3;
        numArr[2] = 5;
        for(int i = 0; i < numArr.Length; i++)
        {
            Debug.Log("numArr[" + i + "] = " + numArr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
