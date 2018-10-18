using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour {


    public Animator unityChanAnim;

	void Start ()
    {
        unityChanAnim = GetComponent<Animator>();
	}
	
	
	void Update ()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            unityChanAnim.SetBool("wait03", true);

        }
        else
        {
            unityChanAnim.SetBool("wait03", false);
        }

        if (Input.GetKey(KeyCode.Alpha2 ))
        {
            unityChanAnim.SetBool("slide00", true);

        }
        else
        {
            unityChanAnim.SetBool("slide00", false);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            unityChanAnim.SetBool("jump00", true);

        }
        else
        {
            unityChanAnim.SetBool("jump00", false);
        }
    }
}
