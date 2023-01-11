using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHands : MonoBehaviour
{
    // input action call either by using a reference (an already existing behaviour) or by creating it here
    [SerializeField] private InputActionProperty _pinchAction;
    // input action call using a reference (an already existing behaviour)
    [SerializeField] private InputActionReference _gripAction;
    // animator component
    [SerializeField] private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float triggerVal = _pinchAction.action.ReadValue<float>();
        _animator.SetFloat("Trigger", triggerVal);

        float gripVal = _gripAction.action.ReadValue<float>();
        _animator.SetFloat("Grip",gripVal);

    }
    
}
