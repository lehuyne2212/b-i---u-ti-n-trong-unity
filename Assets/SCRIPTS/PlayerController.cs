using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(transform.position.x, transform.position.y, 0);
            
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        transform.position += moveInput * moveSpeed * Time.deltaTime;
    }
}
