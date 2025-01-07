using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=6rv5Z8EBXwY&t=11s");
        Debug.Log("This Link is wroking perfect");

    }
}