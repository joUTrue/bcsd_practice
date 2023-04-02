using Mono.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArrayList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList arrayList = new ArrayList();

        Debug.Log(arrayList.Add(123));

        PrintArrayList(arrayList);

        arrayList.Insert(0, 1);
        arrayList.Insert(1,2);

        PrintArrayList(arrayList);

        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(2);
        data.Add(3);
        arrayList.AddRange(data);
        arrayList.AddRange(data);

        PrintArrayList(arrayList);

        arrayList.Sort();

        PrintArrayList(arrayList);

        arrayList.Remove(1);

        PrintArrayList(arrayList);

        arrayList.RemoveAt(0);
        arrayList.RemoveAt(0);

        PrintArrayList(arrayList);

        arrayList.Clear();

        PrintArrayList(arrayList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("-----------------------------------------");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list[{i}]= {list[i]}");
        }
    }
}
