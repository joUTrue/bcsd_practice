using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeHashTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hashtable hashtable = new Hashtable();
        asd _asd = new asd();
        zxc _zxc = new zxc();

        hashtable["asd"] = _asd;
        hashtable.Add("zxc", _zxc);
        hashtable.Add("�Ǽ�", 1.1f);
        hashtable.Add("Ű", "���");
        hashtable.Add(2, "����");

        foreach (object key in hashtable.Keys)
        {
                Debug.Log($"Ű : {key}, ��� : {hashtable[key]}");
        }

        if (hashtable.ContainsKey("Ű"))
        {
            Debug.Log("Ű ����");
        }
        if (hashtable.ContainsValue(_asd))
        {
            Debug.Log("_asd ����");
        }
        Debug.Log($"���� : {hashtable.Count}");

        hashtable.Remove("zxc");
        Debug.Log($"���� : {hashtable.Count}");

        hashtable.Clear();
        Debug.Log($"���� : {hashtable.Count}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class asd
{
}

public class zxc
{

}
