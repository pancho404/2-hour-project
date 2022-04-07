using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    CharacterController player;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3();
        movement.x = h * speed;
        movement.z = v * speed;
        
        player.SimpleMove(movement);
       // transform.Rotate(Vector3.up * v);
       // transform.Rotate(Vector3.up * h);
    }

}
