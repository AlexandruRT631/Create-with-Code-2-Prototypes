using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float verticalAxis;
    [SerializeField] private float horizontalAxis;
    [SerializeField] private float maxAngle = 10;
    private Rigidbody boxRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        boxRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");
        horizontalAxis = Input.GetAxis("Horizontal");
        boxRigidbody.MoveRotation(Quaternion.Euler(maxAngle * horizontalAxis, 0, maxAngle * verticalAxis));
    }
}
