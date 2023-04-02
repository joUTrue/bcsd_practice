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
        hashtable.Add("실수", 1.1f);
        hashtable.Add("키", "밸류");
        hashtable.Add(2, "정수");

        foreach (object key in hashtable.Keys)
        {
                Debug.Log($"키 : {key}, 밸류 : {hashtable[key]}");
        }

        if (hashtable.ContainsKey("키"))
        {
            Debug.Log("키 있음");
        }
        if (hashtable.ContainsValue(_asd))
        {
            Debug.Log("_asd 있음");
        }
        Debug.Log($"개수 : {hashtable.Count}");

        hashtable.Remove("zxc");
        Debug.Log($"개수 : {hashtable.Count}");

        hashtable.Clear();
        Debug.Log($"개수 : {hashtable.Count}");
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
