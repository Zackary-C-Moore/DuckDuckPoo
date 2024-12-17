//=================================================================
//Author  : Zackary Moore
//Date    : 11/06/2024
//Desc    : script to handle the wing flapping animation.  This
//          script will be called by the playercontroller
//          PlayerController will tell this script when it is 
//          time to play the flap animation.  This should happen
//          everytime the user presses the flap button.
//Attached: DuckOuterWing and DuckInnerWing
//Calls   : NULL
//==================================================================

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class WingFlapAnimationController : MonoBehaviour
{
    private Animator animatorController;
    void Start()
    {
        Debug.Log("finding animator");
        animatorController = GetComponent<Animator>();
    }
    public void setBoolWingFlapAnimation(bool flapping)
    {
        Debug.Log("Start animation");
        animatorController.SetBool("Flapping", flapping);
    }

    //Called by animation using event system.
    //function must be public, no return, and not params
    public void onWingFlapAnimationComplete()
    {
        Debug.Log("animation complete");
        animatorController.SetBool("Flapping", false);
    }
}
