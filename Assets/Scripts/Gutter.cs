using UnityEngine;

public class Gutter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter(Collider triggeredBody){
        
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

        ballRigidBody.linearVelocity = Vector3.zero;

        ballRigidBody.angularVelocity = Vector3.zero;

        ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
}
