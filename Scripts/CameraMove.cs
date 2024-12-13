using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pop_up{
    public class CameraMove : MonoBehaviour
    {
        public Transform startPoint;   
        public Transform endPoint;   
        public Transform sunset;     
        public float moveDuration = 1.5f; 
        public float rotateSpeed = 5f; 
        private bool isMoving = false; 
        private float elapsedTime = 0f; 
        private Vector3 startPosition; 
        private Vector3 targetPosition; 
        private Quaternion startRotation; 
        private Quaternion targetRotation; 

        void Start()
        {
            transform.position = startPoint.position;
            transform.rotation = startPoint.rotation;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && !isMoving)
            {
           
                startPosition = transform.position;
                startRotation = transform.rotation;

                if (transform.position == startPoint.position)
                {
                    targetPosition = endPoint.position;
                    targetRotation = endPoint.rotation;
                }
                else if (transform.position == endPoint.position)
                {
                    targetPosition = startPoint.position;
                    targetRotation = startPoint.rotation;
                }

                elapsedTime = 0f; 
                isMoving = true;
            }

            if (isMoving)
            {
                elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(elapsedTime / moveDuration); 

                transform.position = Vector3.Lerp(startPosition, targetPosition, t);

                transform.rotation = Quaternion.Lerp(startRotation, targetRotation, t);

                if (t >= 1f)
                {
                    isMoving = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.F) && !isMoving)
            {
           
                startPosition = transform.position;
                startRotation = transform.rotation;

                if (transform.position == startPoint.position)
                {
                    targetPosition = sunset.position;
                    targetRotation = sunset.rotation;
                }
                else if (transform.position == sunset.position)
                {
                    targetPosition = startPoint.position;
                    targetRotation = startPoint.rotation;
                }

                elapsedTime = 0f; 
                isMoving = true;
            }

            if (isMoving)
            {
                elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(elapsedTime / moveDuration); 

                transform.position = Vector3.Lerp(startPosition, targetPosition, t);

                transform.rotation = Quaternion.Lerp(startRotation, targetRotation, t);

                if (t >= 1f)
                {
                    isMoving = false;
                }
            }
        }
    }
}
