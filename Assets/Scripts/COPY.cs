using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class COPY : MonoBehaviour
{
    [Header("--Camera and movement--")]
    public CharacterController controller;
    public Transform cam;
    public Rigidbody rb;
    public GameObject playerModel;
    public float jumpForce;
    public float speed = 6f;
    public float sprintSpeed = 12f;
    public float turnSmoothTime = 0.1f;
    private float horizontal;
    private float vertical;
    private Vector3 moveDirection;
    float turnSmoothVelocity;
    private bool sprinting = false;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("cursershouldlock");
        rb = GetComponent<Rigidbody>();
    }
    void sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprinting = true;
            speed = sprintSpeed;
            Debug.Log("Sprint should be active");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprinting = false;
            speed = 6f;
            Debug.Log("Sprint should be deactivated");
        }
    }
    void jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);
    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
    private void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * speed;
        vertical = Input.GetAxisRaw("Vertical") * speed;
        rb.velocity = moveDirection;
    }
    void Update()
    {
        moveDirection = transform.forward * vertical + transform.right * horizontal + new Vector3(0, rb.velocity.y, 0);
        if (vertical == 1 * speed && horizontal == 0)
        {
            playerModel.transform.eulerAngles = Vector3.zero;

        }
        if (vertical == -1 * speed && horizontal == 0)
        {
            playerModel.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        sprint();
    }
}