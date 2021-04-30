using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class ThirdPersonInput : MonoBehaviour
{

    public FixedJoystick LeftJoystick;
    //public bl_Joystick Joystick;
    public FixedButton Jbutton;
    public FixedTouchField TouchField;
    public ThirdPersonUserControl Control;
    protected float CameraAngle;
    public float CameraAngleSpeed;
    public float moveSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Control.m_Jump = Jbutton.Pressed;
        //Control.Vinput = TouchField.TouchDist.y * moveSpeed;
        Control.Hinput = LeftJoystick.input.x * moveSpeed;
        Control.Vinput = LeftJoystick.input.y * moveSpeed; 
        //Control.Hinput = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        //Control.Vinput = CrossPlatformInputManager.GetAxisRaw("Vertical");



        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(0, 3, 5);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);

    }
}
