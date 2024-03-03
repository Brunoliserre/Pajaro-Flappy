using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 7;
    public float deadzone = -37;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moving pipe
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //Delete pipe when is offscreen
        if(transform.position.x < deadzone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
