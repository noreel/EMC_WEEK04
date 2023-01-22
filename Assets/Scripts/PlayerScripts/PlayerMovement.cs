using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D RigidBody;
    public float MoveSpeed;
    private Vector2 _moveInput;
    private Vector2 _mousePos;
    public Camera Cam;
     
    [SerializeField]
    private float _rotationSpeed;



    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
      
 
    }


    private void Update()
    {
        _moveInput.x = Input.GetAxisRaw("Horizontal");
        _moveInput.y = Input.GetAxisRaw("Vertical");

        _mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);

       
    }

    private void FixedUpdate()
    {
        RigidBody.MovePosition(RigidBody.position + _moveInput * MoveSpeed * Time.fixedDeltaTime);

        Vector2 LookDir = _mousePos - RigidBody.position;
        float Angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg - 90f;
        RigidBody.rotation = Angle;
    }
}
