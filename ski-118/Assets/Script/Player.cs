using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }

    private void Controller()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 10,ForceMode.Acceleration);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 10, ForceMode.Acceleration);
        }
    }
}
