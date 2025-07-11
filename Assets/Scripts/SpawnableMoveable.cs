using UnityEngine;

public class SpawnableMoveable : MonoBehaviour
{
    //protected allows for subclasses to customize this variable
    //gets rid of getters and setters and allows for unique movement for
    //subclasses
    protected float baseMoveSpeed;

    //This needs to be virtual because it will allow for a default implemntation
    //but child classes can override it to do something different
    //This will be paired with override in the subclass (Car, truck, jet, etc.)
    public virtual void SetSpeed(float speed)
    {
        baseMoveSpeed = speed;
    }
}
