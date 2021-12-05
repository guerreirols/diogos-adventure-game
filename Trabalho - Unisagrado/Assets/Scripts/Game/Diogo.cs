using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diogo : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private GameObject stepsObj;
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private float speed, gravity, rotSpeed, rot;
    public static Vector3 moveDirection;
    public static bool isTalking = false, isWalking = false;

    void Update()
    {
        if (isTalking == false)
        {
            Move();
        }
        if(isTalking == true || Input.GetKeyDown(KeyCode.Escape))
        {
            stepsObj.SetActive(false);
        }
    }

    void Move()
    {
        if(controller.isGrounded)
        {
            if(Input.GetKey(KeyCode.W))
            {
                moveDirection = Vector3.forward * speed;
                anim.SetInteger("transition", 1);
                stepsObj.SetActive(true);
            }
            else if(Input.GetKeyUp(KeyCode.W))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("transition", 0);
                stepsObj.SetActive(false);
            }
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection = transform.TransformDirection(moveDirection);

        controller.Move(moveDirection * Time.deltaTime);
    }
}
