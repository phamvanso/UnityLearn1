using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=10f;
    private float turnSpeed=25f;

    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        
        //we'll move vehicle forward every frame
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //we'll turn vehicle every frame
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
