using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigitbody;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigitbody.position = new Vector2(_rigitbody.position.x, 0.0f);
        _rigitbody.velocity = Vector2.zero;
    }
}
