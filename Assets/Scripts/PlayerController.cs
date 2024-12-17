//=================================================================
//Author  : Zackary Moore
//Date    : 11/06/2024
//Desc    : script to handle the bird: physics, input from
//          user to control bird, bird collisions, pooing,
//          flapping, and gliding.
//Attached: Player
//Calls   : WingFlapAnimationController
//==================================================================



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Needed to apply physics to bird
    private Rigidbody2D rb;
    //How high to move the bird when they flap
    [SerializeField]
    private float flapForce;
    //Glide force to apply to bird in X direction
    [SerializeField]
    private float glideForceX;
    //Glide force to apply to bird in Y direction
    [SerializeField]
    private float glidForceY;
    [SerializeField]
    private float flyForce;
    //Holds all of the different poo objects
    [SerializeField]
    private GameObject[] pooList;
    //Used to determine what to create the poo in the game
    [SerializeField]
    private Transform pooLocation;
    //used to tell physics which button was pressed
    private bool flapping;
    //used to tell physics which button was pressed
    private bool gliding;
    //get a reference to the animator controller used to flap the ducks wings
    private WingFlapAnimationController animController;


    // Start is called before the first frame update
    void Start()
    {
        //find the a
        animController = GetComponent<WingFlapAnimationController>();
        rb = GetComponent<Rigidbody2D>();
        flapping = false;
        gliding = false;
    }
    //=================================================================
    //Handle all input in the update
    //=================================================================
    void Update()
    {
        inputController();
    }
    //=================================================================
    //Handle all physics in fixedupate
    //=================================================================
    void FixedUpdate()
    {
        
        applyPhysicsToBird();
    }
    //=================================================================
    //This will handle all user input given keyboard, mouse, joystick
    //=================================================================
    private void inputController()
    {
        //If you hit space flap
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //set this to true so we can apply physics
            flapping = true;
            //Tell WingFlapAnimationController to play the flap animation
            animController.setBoolWingFlapAnimation(true);
            
        }
        //if you hit left shift glide
        else if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            //set this to true so we can apply physics
            gliding = true;
        }
        //if you hit z poo
        else if(Input.GetKeyDown(KeyCode.Z))
        {
            //call the function to create the poo
            dropPoo();
        }
    }
    //=================================================================
    //This will handle applying physics to the bird flapping, gliding
    //continuous x movement
    //=================================================================
    private void applyPhysicsToBird()
    {
        rb.velocity = new Vector2(flyForce, rb.velocity.y);
        //This if statement booleans will be set by the input controller 
        //so we know what physics to apply
        if(flapping)
        {
            //set flapping back to false and wait for the player to flap
            //again
            flapping = false;
            //apply the flap force to the bird
            rb.velocity = new Vector2(0, flapForce);

            
        }
        else if(gliding)
        {
            //set gliding to false and wait for the player to glide 
            //again
            gliding = false;
            //apply the glide force to the bird
            rb.velocity = new Vector2(glideForceX, glidForceY * -1);
        }
    }
    //=================================================================
    //This will create the poo object to drop and create it at the poo
    //location
    //=================================================================
    private void dropPoo()
    {
        //create the poo in the game at the location pooLocation
        Instantiate(pooList[0], pooLocation.position, pooLocation.rotation);
    }
}
