using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;


public class SnakeController : MonoBehaviour
{
    private Vector2 v2;
    private Vector2Int currentInput;

    public float timeBeforeMove;
    private Rigidbody2D rb;
    private bool IsAlive;
    public GameObject GameOverVanvas;



    private Vector2 emptySpace;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        if (IsAlive)
        StartCoroutine(Move());
        v2 = new Vector2();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;
  
        currentInput = Vector2Int.RoundToInt(v2);

        Debug.Log(currentInput);
        
    }

    IEnumerator Move()
    {

        rb.MovePosition(rb.position + v2 * timeBeforeMove);

        yield return new WaitForSeconds(timeBeforeMove);
           
    }


    private void Die()
    {
        if (!IsAlive)
            return;
     
    }
}
