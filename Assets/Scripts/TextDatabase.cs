using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TextCollection
{
    public string key;
    public string value;
}

[CreateAssetMenu(fileName = "Text_EN.asset", menuName = "Text Asset")]
public class TextDatabase : ScriptableObject
{
    [SerializeField]
    public TextCollection[] collection;

    public string GetText(string key)
    {
        string key_lower = key.ToLower();

        for (int i = 0; i < collection.Length; i++)
        {
            if (key_lower == collection[i].key.ToLower())
                return collection[i].value;
        }

        Debug.LogWarning("Attempt to get string with key: " + key + " failed!");
        return "";
    }
}
