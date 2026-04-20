using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickBtn()
    {
        var bb = Random.Range(111,777);
        Debug.LogError($"-----> {bb}");
    }
}
