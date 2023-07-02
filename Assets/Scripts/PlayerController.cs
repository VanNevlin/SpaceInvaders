using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerMoveSpeed = 4;
    private float playerInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * playerMoveSpeed * playerInput * Time.deltaTime); 
    }
}
