using System.Collections;
using UnityEngine;

public class PlayerEffect : MonoBehaviour
{
    public void AddSpeed(int speedGiven, float speedDuration) 
    {
        PlayerMovement.instance.moveSpeed += speedGiven;
        StartCoroutine(RemoveSpeed(speedGiven, speedDuration));
    }

    public void AddJump(int jumpGiven, float speedDuration)
    {
        PlayerMovement.instance.jumpForce += jumpGiven;
        StartCoroutine(RemoveJump(jumpGiven, speedDuration));
    }

    private IEnumerator RemoveSpeed(int speedGiven, float speedDuration)
    {
        yield return new WaitForSeconds(speedDuration);
        PlayerMovement.instance.moveSpeed -= speedGiven;
    }

    private IEnumerator RemoveJump(int jumpGiven, float speedDuration)
    {
        yield return new WaitForSeconds(speedDuration);
        PlayerMovement.instance.jumpForce -= jumpGiven;
    }
}
