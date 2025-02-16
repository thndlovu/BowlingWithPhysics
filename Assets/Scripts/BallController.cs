using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour{
    [SerializeField] private float force = 1f;
    private bool isBallLaunched;
    private Rigidbody ballRB;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private Transform launchIndicator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        ballRB = GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
        ballRB.isKinematic = true;
    
    }

    // Update is called once per frame
    private void LaunchBall(){
        if(isBallLaunched) return;
        isBallLaunched = true;
        transform.parent = null;
        ballRB.isKinematic = false;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);
    }
}
