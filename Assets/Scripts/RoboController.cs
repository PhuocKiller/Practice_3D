using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RoboController : MonoBehaviour
{
    CharacterController characterController;
    RoboInput roboInput;
    Vector2 inputDirection;
    Vector3 moveDirection;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        roboInput= new RoboInput();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputDirection=roboInput.RoboActions.Move.ReadValue<Vector2>();
        Debug.Log(inputDirection);
    }
    private void OnEnable()
    {
        roboInput.Enable();
    }
    private void OnDisable()
    {
        roboInput.Disable();
    }
    private void FixedUpdate()
    {
        CalculateMove();
    }
    void CalculateMove()
    {
        moveDirection = new Vector3(inputDirection.x, 0, inputDirection.y);
        characterController.Move(moveDirection*4*Time.deltaTime);    
    }
}
