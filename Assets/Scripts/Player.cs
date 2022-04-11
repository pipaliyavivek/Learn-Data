using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody m_rigidbody;
    public float MoveSpeed = .5f;
    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        var Horizonal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(Horizonal* MoveSpeed, 0, Vertical* MoveSpeed);
    }
}
