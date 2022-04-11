using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   //This is a referne=ce to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 1500f;
    public float sidewaysForce = 500f;
    //We marked this as "Fixed" Update because we are using it to mess with physics

    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce *Time.deltaTime);

        if (Input.GetKey("d"))
        {
           rb.AddForce(sidewaysForce *Time.deltaTime,0,0, ForceMode.VelocityChange);

        }

                if (Input.GetKey("a"))
        {
           rb.AddForce(-sidewaysForce *Time.deltaTime,0,0,ForceMode.VelocityChange);

        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }



    }
}
