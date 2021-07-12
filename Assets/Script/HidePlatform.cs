using UnityEngine;

public class HidePlatform : MonoBehaviour
{
    public SpriteRenderer graphics;
    public PlatformEffector2D platform;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.enabled == true)
        {
            graphics.color = new Color(1f, 1f, 1f, 1f);
            platform.enabled = false;
        }
    }
}
