using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float power;
    public Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
 private void OnTriggerEnter(Collider other)
    {   
            if (other.gameObject.tag == "Right")
            {
                Debug.Log("in1");
                GameFlag.changeflag = 1;
            }
            else if (other.gameObject.tag == "Left")
            {
                Debug.Log("in2");
                GameFlag.changeflag = 2;
            }
            else if (other.gameObject.tag == "Up")
            {
                Debug.Log("in3");
                GameFlag.changeflag = 3;
            }
            else if (other.gameObject.tag == "Down")
            {
                Debug.Log("in4");
                GameFlag.changeflag = 4;
            }
        }
   
    // Update is called once per frame
    void Update()
    {
        //rigidbody.gravity

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 1, 0) * power);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, -1, 0) * power);
        }
    }
}
