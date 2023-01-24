using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{

    private Animator mAnimator;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        player = GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            mAnimator.SetTrigger("attack");
        }
    }
}
