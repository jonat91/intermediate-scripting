﻿using UnityEngine;

namespace Quaternions
{
    public class LookAtScript : MonoBehaviour 
    {
        public Transform target;
        
        void Update () 
        {
            Vector3 relativePos = target.position - transform.position;
            transform.rotation = Quaternion.LookRotation(relativePos);
        }
    }
}
