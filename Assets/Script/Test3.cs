using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 10;
        int num2 = 3;

        Debug.Log(num1 + " + " + num2 + " = " + (num1 + num2));
        Debug.Log(num1 + " - " + num2 + " = " + (num1 - num2));
        Debug.Log(num1 + " * " + num2 + " = " + (num1 * num2));
        Debug.Log(num1 + " / " + num2 + " = " + (num1 / num2));
        Debug.Log(num1 + " % " + num2 + " = " + (num1 % num2));

        string firstName = "YeongBu";
        string lastName = "Yeo";
        string maName = firstName + " " +lastName;
        Debug.Log(maName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
