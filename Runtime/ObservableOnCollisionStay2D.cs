using UnityEngine;

public class ObservableOnCollisionStay2D : MonoBehaviour
{
    public delegate void EventHandler(Collision2D collision);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        onEvent?.Invoke(collision);
    }
}
