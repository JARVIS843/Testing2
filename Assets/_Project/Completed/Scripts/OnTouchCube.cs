using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InfallibleCode.Completed
{
    
    public class OnTouchCube : MonoBehaviour
    {
        public event Action Cube;
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Touched");
            if(other.CompareTag("Player"))
            {
                Cube?.Invoke();
            }
        }

    }

}