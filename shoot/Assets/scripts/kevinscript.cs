using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent (typeof(CharacterController))]
public class kevinscript : MonoBehaviour {

    public float movementSpeed = 5.0f;
    public float mouseSpeed = 5.0f;
    float verticalRotation = 0;
    public float UpDownRange = 60.0f;
    float verticalVelocity = 0;
    public float jumpSpeed = 7.5f;
    CharacterController characterController;
    // Use this for initialization
    void Start () {
        Screen.lockCursor = true;
        characterController = GetComponent<CharacterController>();

    }
	
	// Update is called once per frame
	void Update () {

        //rotation
        float rotSide = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0, rotSide, 0);
       // AudioSource footstep = GetComponent<AudioSource>();

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSpeed;
        verticalRotation = Mathf.Clamp(verticalRotation, -UpDownRange, UpDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler( verticalRotation, 0, 0 );
        //movement
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        if(characterController.isGrounded && Input.GetButton("Jump")){
            verticalVelocity = jumpSpeed;
        }



       
        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);
        speed = transform.rotation * speed;
       
        characterController.Move(speed * Time.deltaTime);
	}


}
