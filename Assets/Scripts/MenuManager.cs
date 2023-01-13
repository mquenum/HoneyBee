using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private InputActionReference _menuAction;
    [SerializeField] private GameObject _menu;
    // Start is called before the first frame update
    void Start()
    {
        // activate input action (avoid listening all the time in Update)
        _menuAction.action.Enable();
        // add function to launch
        _menuAction.action.performed += DisplayMenu;
    }

    private void DisplayMenu(InputAction.CallbackContext obj)
    {
        // if GO is active
        if (_menu.activeSelf)
        {
            _menu.SetActive(false);
        }
        else
        {
            _menu.SetActive(true);
        }
    }
}
