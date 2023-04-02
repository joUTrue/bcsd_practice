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

        Debug.Log($"마지막 추가 요소 : {stack.Peek()}");
        Debug.Log($"삭제된 데이터 : {stack.Pop()}");

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
