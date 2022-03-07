using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    public float thrust;
 
    void Start()
    {
   
        StatusBarHandler.SetStatusBarValue(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
             StatusBarHandler.SetStatusBarValue(StatusBarHandler.GetStatusBarValue() + 0.5f*Time.deltaTime);

        else if (Input.GetKeyUp(KeyCode.O) && (StatusBarHandler.GetStatusBarValue() > .65f))
              StatusBarHandler.SetStatusBarValue(.65f);

        if (Input.GetKey(KeyCode.I))
            StatusBarHandler.SetStatusBarValue(StatusBarHandler.GetStatusBarValue() - 0.1f * Time.deltaTime);
        thrust = StatusBarHandler.GetStatusBarValue() * 1.5f;
        Debug.Log(thrust);
    }
} //amended file
