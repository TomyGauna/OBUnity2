using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    public int turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontal);
    }

    void fixedUpdate()
    {
        
    }
}
