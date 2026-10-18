using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private Transform target;
    public float damage;
    public float hitWaitTime = 1f;
    private float hitCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = FindAnyObjectByType<PlayerController>().transform;
        
    }

    // Update is called once per frame
    
    void Update()
    {
        rb.linearVelocity = (target.position - transform.position).normalized * moveSpeed;   
    }
    if (hitCounter > 0)
{
    hitCounter -= Time.deltaTime;
}
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && hitCounter <= 0)
        {
            PlayerHealthController.instance.TakeDamage(damage);
            PlayerHealthController.instance.TakeDamage(damage);
            hitCounter = hitWaitTime;

        }
    }
}

