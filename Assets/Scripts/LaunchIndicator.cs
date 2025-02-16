using UnityEngine;
using Unity.Cinemachine;
public class Indicator : MonoBehaviour{
    [SerializeField] private CinemachineCamera freeLookCamera;

    // Update is called once per frame
    void Update(){
        transform.forward = freeLookCamera.transform.forward;
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
