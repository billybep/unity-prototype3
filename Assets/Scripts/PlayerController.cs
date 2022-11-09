using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        rbPlayer.AddForce(Vector3.up * 450);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
