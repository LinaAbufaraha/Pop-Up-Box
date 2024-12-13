using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pop_up{
    public class controlhandle : MonoBehaviour
    {
        public float rotationSpeed = 20f;
        float handleAngle = -33.5f;
    
        public float minRotation = -33.5f; 
        public float maxRotation = 100f; 
        void Start()
        {
        
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow)) // Right
            {  
                handleAngle += Time.deltaTime * rotationSpeed;
                RotateHandle();
            }
            else if (Input.GetKey(KeyCode.LeftArrow)) // Left
            {
                handleAngle -= Time.deltaTime * rotationSpeed;
                RotateHandle();
            }
        
        }

        private void RotateHandle()
        {
            handleAngle = Mathf.Clamp(handleAngle,minRotation , maxRotation);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, handleAngle));
        
        }

    }

}
