using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Queue queue = new Queue();

        for (int i = 0; i < 4; i++)
        {
            queue.Enqueue(i);
        }

        PrintQCount(queue);

        Debug.Log($"žť : {queue.Peek()}");

        object data = queue.Dequeue();
        Debug.Log($"������ ������ : {queue.Dequeue()}");

        PrintQCount(queue);

        queue.Clear();

        PrintQCount(queue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintQCount(Queue _queue)
    {
        Debug.Log($"QueueCount : {_queue.Count}");
    }
}
