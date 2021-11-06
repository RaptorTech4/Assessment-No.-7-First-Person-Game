using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 11.5f;
    public float crouchSpeed = 5.5f;

    [Header("gravity")]
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    [Header("Camera")]
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;

    [Header("Outside var that impact player")]
    public BoolObject PauseMenuActive;
    public BoolObject PlayerLost;
    public BoolObject PlayerWin;
    public BoolObject canMove;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    

    void Start()
    {
        canMove.value = true;
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (!PauseMenuActive.value && !PlayerLost.value && !PlayerWin.value)
        {
            Movement();
        }
    
        RaycastHit hit;
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, 10.0f))
            {
                if(hit.collider != null)
                {
                    if(hit.transform.gameObject.tag == "KeyPad")
                    {
                        KeyPad(hit.transform.gameObject);
                    }
                }
            }
        }
    }

    public void KeyPad(GameObject hit)
    {
        if (hit.transform.GetComponent<AddNumberToString>() != null)
        {
            hit.transform.GetComponent<AddNumberToString>().AddNumber();
        }

        if (hit.transform.GetComponent<ClearNumbersOfString>() != null)
        {
            hit.transform.GetComponent<ClearNumbersOfString>().removeAllNumber();
        }
        
        if (hit.transform.GetComponent<VerifaiNumberString>() != null)
        {
            hit.transform.GetComponent<VerifaiNumberString>().CheckIfPasswordIsCorrect();
        }

        if (hit.transform.GetComponent<PlaySound>() != null)
        {
            hit.transform.GetComponent<PlaySound>().PlayASound();
        }
    }

    public void Movement()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetButton("Run");
        bool isCrouch = Input.GetButton("Crouch");

        float curSpeedX = canMove.value ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        curSpeedX = canMove.value ? (isCrouch ? crouchSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;

        float curSpeedY = canMove.value ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        curSpeedY = canMove.value ? (isCrouch ? crouchSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;

        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove.value && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        characterController.height = isCrouch ? 1f : 2f;

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove.value)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }
}
