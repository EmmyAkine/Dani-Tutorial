using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] ObjectBehaviour objectBehaviour;

    private float playerSpeed = 20f;
    private float inputHorizontal; 

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        objectBehaviour.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

      if(inputHorizontal != 0)
        {
            rb.AddForce(new Vector2(inputHorizontal * playerSpeed, 0));
        }

    }


}
