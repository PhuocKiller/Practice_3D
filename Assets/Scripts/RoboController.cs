using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController : MonoBehaviour
{
    CharacterController characterController;
    RoboInput roboInput;
    Vector2 inputDirection;
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
}
