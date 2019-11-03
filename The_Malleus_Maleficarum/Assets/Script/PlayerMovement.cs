using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private LookMouse LM;

    public float WalkSpeed = 6.0F;
    public float RunSpeed = 8.0F;

    void Start()
    {
        LM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookMouse>();
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, LM.yRotation, 0);
        MoveMent();
    }

    void MoveMent()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A D 左右
        float vertical = Input.GetAxis("Vertical"); //W S 上 下

        transform.Translate(Vector3.forward * vertical * WalkSpeed * Time.deltaTime);//W S 上 下
        transform.Translate(Vector3.right * horizontal * WalkSpeed * Time.deltaTime);//A D 左右
    }
}
