using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndStopAnimator : MonoBehaviour
{
    public static bool isShooting;
    Animator animator;
    //GameObject waterGun = GameObject.Find("WaterGun");

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WaterGunActivated()
    {
        if (isShooting)
        {
            animator.enabled = false;
        }
        else
        {
            animator.enabled = true;
        }
    }

}
