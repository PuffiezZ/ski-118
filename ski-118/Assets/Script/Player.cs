using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float forcePower = 10;

    private Rigidbody rb;

    [SerializeField] private int hp = 3;
    public int HP {  get { return hp; } set { hp = value; } }

    [SerializeField] private int point = 0;
    public int Point { get { return point; } set { point = value; } }

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
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(horizontal * Vector3.right * forcePower);
    }
}
