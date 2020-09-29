using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public enum motionDirections { Spin, Horizontal, Vertical,Front };
    public motionDirections motionState = motionDirections.Horizontal;

    public float spinSpeed=180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = true;
    public bool doMotion = false;
    
    // Update is called once per frame
    void Update()
    {
        switch (motionState)
        {
            case motionDirections.Spin:
                this.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);break;
            case motionDirections.Horizontal:
                this.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude); break;
            case motionDirections.Vertical:
                this.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);break;
            case motionDirections.Front:
                this.transform.Translate(Vector3.forward * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude); break;


        }
       
      
    }
}
