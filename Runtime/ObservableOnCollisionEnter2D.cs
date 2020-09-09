using UnityEngine;

public class ObservableOnCollisionEnter2D : MonoBehaviour
{
    public delegate void EventHandler(Collision2D collision);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onEvent?.Invoke(collision);
    }
}
