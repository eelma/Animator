using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanRun : MonoBehaviour {

    public Animator unityChan;

    public CharacterController characterController;
    public float speed = 3;
    public float bSpeed = 0.1f;


	void Start ()
    {
        unityChan = GetComponent<Animator>();

        characterController = GetComponent<CharacterController>();
	}


    void Update()
    {
        float v = Input.GetAxis("Vertical"); // edit의 프로젝트 셋팅의 인풋 버티컬을 말함
        float h = Input.GetAxis("Horizontal"); // edit의 프로젝트 셋팅의 인풋 홀리젠탈을 말함

        unityChan.SetFloat("V", v);
        unityChan.SetFloat("H", h);


        Vector3 dir = transform.forward * v; //로컬좌표의 포워드
        //Vector3 dir = Vector3.forward * v; //월드좌표의 포워드이므로 아님

        if (v < 0)
        {
            dir *= bSpeed;
            transform.Rotate(0, -h * 45f * Time.deltaTime, 0);
        }
        else
        {
            dir *= speed;
            transform.Rotate(0, h * 45f * Time.deltaTime, 0);
        }

        characterController.Move(dir * Time.deltaTime);


        /*--------------------------- 같은 의미 ---------------------------*/
        //if (v < 0)
        //{
        //    transform.Translate(0, 0, v * bSpeed * Time.deltaTime);
        //    transform.Rotate(0, -h * 45f * Time.deltaTime, 0);
        //}
        //else
        //{
        //    transform.Translate(0, 0, v * speed * Time.deltaTime);
        //    transform.Rotate(0, h * 45f * Time.deltaTime, 0);
        //}
        /*--------------------------- 같은 의미 ---------------------------*/
    }
}
