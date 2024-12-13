using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pop_up{

    public class OpeningDoor : MonoBehaviour
    {
        public float speed = 20f;
        public float minPosition = 17f;
        public float maxPosition = 23.7f;

        public float positionFactor = 17f;

        void Start()
        {
        }
    
        void Update()
        {
            if (Input.GetKey(KeyCode.A)){
       
            positionFactor+= Time.deltaTime*speed ;
        }

        positionFactor = Mathf.Clamp(positionFactor, minPosition, maxPosition);

        transform.position = new Vector3(positionFactor,  transform.position.y , transform.position.z);

        
        }
    }

}
