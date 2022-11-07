using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Player;
    public int changeflag = 0;
    public int delay = 120;
    // Start is called before the first frame update
    void Start()
    {
        GameFlag.changeflag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        changeflag = GameFlag.changeflag;
    }

   

        private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "Player"&& GameFlag.changeflag == 2)
            {
                Debug.Log("in1");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
            }
            else if (other.gameObject.tag == "Player" && GameFlag.changeflag == 1)
            {
                Debug.Log("in2");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
            }
            else if (other.gameObject.tag == "Player" && GameFlag.changeflag == 3)
            {
                Debug.Log("in3");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
            }
            else if (other.gameObject.tag == "Player" && GameFlag.changeflag == 4)
            {
                Debug.Log("in4");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 90);
            } 

    }

    private void OnTriggerExit(Collider other)
    {
        if (GameFlag.changeflag != 0)
        {
            GameFlag.changeflag = 0;
            Debug.Log("out");
        }
    }
}
