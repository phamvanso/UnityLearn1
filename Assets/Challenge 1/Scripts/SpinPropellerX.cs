using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{ 
    // Update is called once per frame
    public float RotationSpeed = 1000f;
    void Update()
    {
        transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
    }
}
