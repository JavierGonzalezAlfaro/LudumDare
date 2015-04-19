using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

        public KeyCode rightKey = KeyCode.D;
        public KeyCode leftKey = KeyCode.A;
        public KeyCode upKey = KeyCode.W;
        public KeyCode downKey = KeyCode.S;

        void Start()
        {
        }

        void Update()
        {
            if (Input.GetKey(rightKey)) rightMovement();
            if (Input.GetKey(leftKey)) leftMovement();
            if (Input.GetKey(upKey)) upMovement();
            if (Input.GetKey(downKey)) downMovement();
        }

        void rightMovement()
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + 0.5f);
        }
        void leftMovement()
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - 0.5f);
        }
        void upMovement()
        {
            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
        }
        void downMovement()
        {
            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
        }

}

