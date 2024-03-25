using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float velocity = 5f;

    public enum Direction { Up, Right, Down, Left, None }

    public Direction direction = Direction.None;

    public GameObject player;
    float horizontal = 0;
    float vertical = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction = direction.normalized * velocity * Time.deltaTime;

        player.transform.Translate(direction);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (direction == Direction.Up)
        {
            vertical = 1;
        }
        if (direction == Direction.Down)
        {
            vertical = -1;
        }
        if (direction == Direction.Right)
        {
            horizontal = 1;
        }
        if (direction == Direction.Left)
        {
            horizontal = -1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        vertical = 0;
        horizontal = 0;
    }
}
