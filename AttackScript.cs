using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class AttackScript : MonoBehaviour
{
    public Animator animator;
    public Vector2 moveInput;
    public Vector2 lastMoveDirection;
    public GameObject hitbox;
    public GameObject swordY;
    public Transform Aim;
    bool isAttacking = false;
    bool isWalking = false;
    float attackDuration = 0.3f;
    float attackTimer = 1f;
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        if (moveInput != Vector2.zero)
        {
            isWalking = true;
            lastMoveDirection = moveInput;
            Vector3 vector3 = Vector3.left * moveInput.x + Vector3.down * moveInput.y;
            Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
        }
        else
        {
            isWalking = false;
            Vector3 vector3 = Vector3.left * lastMoveDirection.x + Vector3.down * lastMoveDirection.y;
            Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
        }
        Attack();
    }
    void Attack()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking = true;
            hitbox.SetActive(true);
            attackTimer = attackDuration;
            swordY.SetActive(true);
        }
        else if (isAttacking)
        {
            attackTimer -= Time.deltaTime;
            if (attackTimer <= 0f)
            {
                isAttacking = false;
                hitbox.SetActive(false);
                swordY.SetActive(false);
            }
        }
    }
}
