using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{

    [SerializeField] InputAction movement;

    [SerializeField] InputAction fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalThrow = movement.ReadValue<Vector2>().x;
        float verticalThrow = movement.ReadValue<Vector2>().y;

        Debug.Log(horizontalThrow);
        Debug.Log(verticalThrow);


        /*float horizontalThrow = Input.GetAxis("Horizontal");
        Debug.Log(horizontalThrow);
        float verticalThrow = Input.GetAxis("Vertical");
        Debug.Log(verticalThrow);*/


    }
}
