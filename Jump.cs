using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce;
    public float move;
    public float DirR;
    public float DirL;
    public float back;
    private const walkspeed = 5.0f;
    private const sprintspeed = 10.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            GetComponent<Rigidbody>().velocity = Vector3.forward * move;
        
        }
        if(Input.GetKeyDown(KeyCode.S)){
            GetComponent<Rigidbody>().velocity = Vector3.back * back;
        }
        if(Input.GetKeyDown(KeyCode.A)){
           GetComponent<Rigidbody>().velocity = Vector3.left * DirL;
        }
        if(Input.GetKeyDown(KeyCode.D)){
           GetComponent<Rigidbody>().velocity = Vector3.right * DirR;
        }
    }
}
