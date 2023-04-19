using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Jump");

        rb.AddForce(Vector3.forward * y * speed * 100 * Time.deltaTime);
        rb.AddForce(Vector3.right * x * speed * 100 * Time.deltaTime);
        rb.AddForce(Vector3.up * z * speed *100* Time.deltaTime);
    }
}
