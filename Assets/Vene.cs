using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vene : MonoBehaviour
{

    public Rigidbody rb;
    public float forceAmount;
    public float torque;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))  
        {  
            rb.AddRelativeTorque(transform.up * torque * Time.fixedDeltaTime * -1);
        }  
        if (Input.GetKey(KeyCode.D))  
        {  
            //rb.AddForce(Vector3.right * forceAmount * Time.deltaTime, ForceMode.Impulse); 
            //rb.AddForceAtPosition(Vector3.right * torque * Time.deltaTime, rotatePoint);
            rb.AddRelativeTorque(transform.up * torque * Time.fixedDeltaTime);
        }  
        if (Input.GetKey(KeyCode.S))  
        {  
            rb.AddForce(-transform.forward * forceAmount * Time.fixedDeltaTime, ForceMode.Acceleration); 
        }  
        if (Input.GetKey(KeyCode.W))  
        {  
            rb.AddForce(transform.forward * forceAmount * Time.fixedDeltaTime, ForceMode.Acceleration); 
            
        } 
    }
}
