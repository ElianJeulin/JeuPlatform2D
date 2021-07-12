using System.Collections;
using UnityEngine;

public class PoisonDamage : MonoBehaviour
{
    public CircleCollider2D poisonCollider;
    public int timeDuration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(30);
        }
    }

    public IEnumerator PauseDuration()
    {
        yield return new WaitForSeconds(timeDuration);
    }
}
