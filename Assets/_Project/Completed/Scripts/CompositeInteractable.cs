using System.Collections.Generic;
using UnityEngine;

namespace InfallibleCode.Completed
{
    public class CompositeInteractable : MonoBehaviour, IInteractable
    {

        
        [SerializeField] private List<GameObject> interactables;
        private OnTouchCube TouchCube;

        /// <summary>
        /// This function is called when the object becomes enabled and active.
        /// </summary>
        void OnEnable()
        {
            TouchCube = FindObjectOfType<OnTouchCube>();
            TouchCube.Cube +=Interact;
        }
        public void Interact()
        {
            print("Interact");
            foreach (var go in interactables)
            {
                var interactable = go.GetComponent<IInteractable>();
                interactable?.Interact();
            }
        }
    }
}