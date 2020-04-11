using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour{
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start(){
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        ProcessInput();
    }

    void ProcessInput() {
        bool leftRotation = Input.GetKey(KeyCode.A);
        bool rightRotation = Input.GetKey(KeyCode.D);

        if (Input.GetKey(KeyCode.Space)) {  //rocket can thrust
            rigidBody.AddRelativeForce(Vector3.up);
        }

        if(leftRotation && rightRotation) { //rocket cant rotate both ways
            //do nothing
        }
        else if(leftRotation) {
            print("Rotating left");
        }
        else if (rightRotation) {
            print("Rotating Right");
        }

    }
}
