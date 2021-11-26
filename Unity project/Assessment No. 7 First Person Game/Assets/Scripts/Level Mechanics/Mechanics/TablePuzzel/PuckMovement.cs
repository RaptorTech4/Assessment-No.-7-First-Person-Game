using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckMovement : MonoBehaviour
{

    [SerializeField]
    BoolObject canMove;
    [SerializeField]
    BoolObject moveRight;
    [SerializeField]
    BoolObject moveLeft;
    [SerializeField]
    BoolObject moveUp;
    [SerializeField]
    BoolObject moveDown;

    Vector3 movePuckTo;

    public LayerMask raycastNotToHit;

    void Start()
    {
        canMove.value = true;
    }

    
    void Update()
    {
        if(canMove.value)
        {
            if (moveUp.value)
            {
                MoveUp();
            }

            if(moveDown.value)
            {
                MoveDown();
            }

            if (moveLeft.value)
            {
                MoveLeft();
            }

            if (moveRight.value)
            {
                MoveRight();
            }

        }

    }

    void MoveUp()
    {
        RaycastHit hit;
        Vector3 puckSpace;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity))
        {
            puckSpace = new Vector3(0f,0f, -0.04f);
            CalcilatPositionToMove(hit.point, puckSpace); 
        }
        moveUp.value = false;
    }

    void MoveDown()
    {
        RaycastHit hit;
        Vector3 puckSpace;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, Mathf.Infinity))
        {
            puckSpace = new Vector3(0f, 0f, 0.04f);
            CalcilatPositionToMove(hit.point, puckSpace);
        }
        moveDown.value = false;
    }

    void MoveLeft()
    {
        RaycastHit hit;
        Vector3 puckSpace;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, raycastNotToHit))
        {
            puckSpace = new Vector3(0.04f, 0f, 0f);
            CalcilatPositionToMove(hit.point, puckSpace);
        }
        moveLeft.value = false;
    }

    void MoveRight()
    {
        RaycastHit hit;
        Vector3 puckSpace;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, Mathf.Infinity))
        {
            puckSpace = new Vector3(-0.04f, 0f, 0f);
            CalcilatPositionToMove(hit.point, puckSpace);
        }
        moveRight.value = false;
    }

    void CalcilatPositionToMove(Vector3 hitpoint, Vector3 direction)
    {
        canMove.value = false;
        movePuckTo = new Vector3(hitpoint.x - direction.x, hitpoint.y - direction.y, hitpoint.z - direction.z);
        
        Debug.Log("MoveTo" + hitpoint);

        StartCoroutine(LerpPosition(movePuckTo, 3));
    }

    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        float distance = Vector3.Distance(transform.position, targetPosition);
        float speed = distance / duration;

        Vector3 startPosition = transform.position;

        while (time < speed)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / speed);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
        canMove.value = true;
    }

}
