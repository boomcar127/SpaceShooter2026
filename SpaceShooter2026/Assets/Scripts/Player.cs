using UnityEngine;

public class Player : MonoBehaviour
{
    private SpaceShooterInputActions inputActions;
    public float speed = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        inputActions = new();
        inputActions.Enable();
        inputActions.Standard.Enable();
        
    }

    // Update is called once per frame
    private void Update() {
        if (inputActions.Standard.MoveUp.IsPressed())
        {
            this.transform.Translate(Vector3.up * speed);
        }
        else if (inputActions.Standard.MoveDown.IsPressed()) {
            this.transform.Translate(Vector3.down * speed);
        }
}
