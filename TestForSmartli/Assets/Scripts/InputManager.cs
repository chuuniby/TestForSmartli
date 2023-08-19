using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public static InputManager Instance
    {
        get { return instance; }
    }

    public PlayerInputs playerInputs;
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        playerInputs = new PlayerInputs();
    }
    private void OnEnable()
    {
        playerInputs.Enable();
    }
    private void OnDisable()
    {
        playerInputs.Disable();
    }
    public Vector2 GetPlayerMovement()
    {
        return playerInputs.Player.Move.ReadValue<Vector2>();
    }
    public Vector2 GetMouseDelta()
    {
        return playerInputs.Player.Look.ReadValue<Vector2>();
    }
    public bool PlayerJumpedThisFrame()
    {
        return playerInputs.Player.Jump.triggered;
    }
}
