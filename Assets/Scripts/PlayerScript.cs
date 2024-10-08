using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("--Camera and movement--")]
    public CharacterController controller;
    public Transform cam;
    public float speed = 6f;
    public float baseSpeed = 12f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    private bool sprinting = false;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("cursershouldlock");
    }
    void sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprinting = true;
            Debug.Log("Sprint should be active");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprinting = false;
            Debug.Log("Sprint should be deactivated");
        } 
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

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
        }
        sprint();
    }
}
