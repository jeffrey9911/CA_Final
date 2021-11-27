using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovements : MonoBehaviour
{


    public Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("MOVE!");
            _animator.SetInteger("testMove", 1);
        }
        



    }


}
