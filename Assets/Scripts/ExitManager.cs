using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class ExitManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset playerActions;
    private InputAction _exitAction;
    
    private void Awake()
    {
        _exitAction = playerActions.FindAction("Exit", throwIfNotFound: true);
    }

    private void Update()
    {
        if (_exitAction.triggered)
            Application.Quit();
    }
}
