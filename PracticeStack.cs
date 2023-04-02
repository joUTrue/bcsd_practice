using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }

        PrintStkCount(stack);

        Debug.Log($"������ �߰� ��� : {stack.Peek()}");
        Debug.Log($"������ ������ : {stack.Pop()}");

        PrintStkCount(stack);

        stack.Clear();

        PrintStkCount(stack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintStkCount(Stack _stack)
    {
        Debug.Log($"StackCount : {_stack.Count}");
    }
}
