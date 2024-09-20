using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    public bool multiplayerMode = false;
    private Vector2 _direction;

    private void Update()
    {
        if (multiplayerMode)
        {
            if (Input.GetKey(KeyCode.UpArrow)){
                _direction = Vector2.up;
            } else if(Input.GetKey(KeyCode.DownArrow)){
                _direction = Vector2.down;
            } else {
                _direction = Vector2.zero;
            }
        }
    }

    private void FixedUpdate()
    {
        if (!multiplayerMode && this.ball.velocity.x > 0.0f){
            if (this.ball.position.y > this.transform.position.y){
                _rigitbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y){
                _rigitbody.AddForce(Vector2.down * this.speed);
            }
        } else if (!multiplayerMode) {
            if (this.transform.position.y > 0.0f) {
                _rigitbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f ) {
                _rigitbody.AddForce(Vector2.up * this.speed);
            }
        }

        if (multiplayerMode)
        {
            if (_direction.sqrMagnitude != 0){
                _rigitbody.AddForce(_direction * this.speed);
            }
        }
    }
}
