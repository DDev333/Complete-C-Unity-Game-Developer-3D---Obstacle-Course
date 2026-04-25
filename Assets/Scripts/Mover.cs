using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInst();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void PrintInst()
    {
        Debug.Log("Welcome to the Obstacle Course");
        Debug.Log("Move the cube with arrow keys or WASD");
        Debug.Log("Don't hit the walls");
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
