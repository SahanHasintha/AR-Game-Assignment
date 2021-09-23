using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    void Awake()
    {
        GameObject[] Objs = GameObject.FindGameObjectsWithTag("Music");
        print(Objs);
        if (Objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
