using UnityEngine;

public class PlantsAttack : MonoBehaviour
{
    public Animator animator;
    public bool isInRange;

    public GameObject objectToDestroy;


    private void Update()
    {
        animator.SetBool("isInRange", isInRange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(objectToDestroy);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
    }
}
