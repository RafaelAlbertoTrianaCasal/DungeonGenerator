using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;

    private Vector3 playerPosition;
    private Quaternion playerRotation;

    private Animator anim;
    public float X, Y;

    void start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        anim.SetFloat("VelX", X);
        anim.SetFloat("VelY", Y);
    }

   
}
