using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("MyFirstScript Awake function");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MyFirstScript Start function");  
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButton(0))
        {
            Debug.Log("Update Input F pressed");
        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Update Input F");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Update Input F released");
        }
    }

    private void LateUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
