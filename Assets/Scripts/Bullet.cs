using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<GameManager>().AddScore(10);
            SoundManager.instance.PlayEnemyDeathSound();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
