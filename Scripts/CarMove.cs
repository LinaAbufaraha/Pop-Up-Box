using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pop_up{
    public class CarMove : MonoBehaviour
    {
        public float speed = 20f;
        public float firstPosition ;
        public float finalPosition = -40 ;

        public float positionFactor ;


        void Start()
        {
            transform.position =new Vector3(transform.position.x, transform.position.y , transform.position.z); 
            positionFactor=transform.position.x; 
            firstPosition=transform.position.x; 
        }

    
        void Update()
        {
            if (Input.GetKey(KeyCode.W)){

            positionFactor-= Time.deltaTime*speed ;

            }
            transform.position = new Vector3(positionFactor , transform.position.y , transform.position.z);
        
        
        }
    }
}
