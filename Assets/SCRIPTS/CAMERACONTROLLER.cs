using UnityEngine;

public class CAMERACONTROLLER : MonoBehaviour
{
    private Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = FindAnyObjectByType<PlayerController>().transform;

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
 
    }
}
