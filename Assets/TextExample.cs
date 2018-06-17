using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextExample : MonoBehaviour
{
    [SerializeField]
    TextDatabase text;

	void Start ()
    {
        Debug.Log(text.GetText("test1"));
        Debug.Log(text.GetText("TEST1"));
        Debug.Log(text.GetText("tEsT1"));
    }
	
	void Update ()
    {
		
	}
}
