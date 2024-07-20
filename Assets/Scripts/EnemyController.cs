using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().GameOver();
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
