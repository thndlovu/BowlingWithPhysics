using UnityEngine;

public class Gutter : MonoBehaviour{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter(Collider triggeredBody){
        
        if(!triggeredBody.CompareTag("Ball")) return;

        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        if(ballRigidBody != null){
        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

        ballRigidBody.linearVelocity = Vector3.zero;

        ballRigidBody.angularVelocity = Vector3.zero;

        ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
        }
    }
}
