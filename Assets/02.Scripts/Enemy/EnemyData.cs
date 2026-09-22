using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    [Header("공통 능력치")]
    public float MaxHp;
    public float MoveSpeed;
    public float DetectRange;

    [Space(50)]

    [Header("공격 능력치")]
    public float AttackDamage;
    public float AttackDetectRange;
    public float AttackPrepareTime;
    public float AttackRecoveryTime;

    [Space(50)]

    [Header("원거리 탄막")]
    public float ProjectileSpeed;
    public int ProjectileCount;
    public float ProjectileInterval;

    [Space(50)]

    [Header("버프 능력치")]
    public float AttackBuffAmount;
    public float BuffRange;
}
