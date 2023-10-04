using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopka : MonoBehaviour
{
    public GameObject Object1;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start_obj1()
    {
        flag = Object1.activeSelf;
        Object1.SetActive(!flag);
    }
}

