using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Camera           mainCamera;
    private Transform       localTransform;
    Vector3                 mousePos;
    Animation               Anim;
    private Vector3         lastMousePos;
    private Vector3         newPosForTrans;

    public float            speed = 5f;
    private bool            isHeld = false;

    // Start is called before the first frame update
    private void Awake()
    {
        Anim = GetComponent<Animation>();
    }

    private void Start()
    {
        localTransform = GetComponent<Transform>();
    }
    private void Update()
    {
        mousePos = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, 10f));
        float xDiff = mousePos.x - lastMousePos.x;

        newPosForTrans.x = localTransform.position.x + xDiff * Time.deltaTime * 5.0f;
        newPosForTrans.y = localTransform.position.y;
        newPosForTrans.z = localTransform.position.z;
        if (Input.GetMouseButtonDown(0) || isHeld == true)
        {
            Anim.Play("Run");
            isHeld = true;
            localTransform.position = newPosForTrans + 
                localTransform.forward * speed * Time.deltaTime;
            lastMousePos = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            localTransform.position = newPosForTrans;
            lastMousePos = mousePos;
            Anim.Play("Idle");
            isHeld = false;
        }
    }
}
