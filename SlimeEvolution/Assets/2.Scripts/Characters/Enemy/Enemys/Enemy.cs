using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected int hitPoint;
    protected int attackPoint;
    protected float movingSpeed;
    protected EnemyState state;
    protected SpecialSkillIMP skill;
    protected AttackIMP attack;
    protected MovementIMP movement;

    protected abstract void Attack();
    protected abstract void Move();
    protected abstract void UseSkill();
    protected void Death()
    {

    }

	
}
