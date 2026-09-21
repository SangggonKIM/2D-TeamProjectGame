public static class Constants
{
    #region Tags
    public static class Tags
    {
        public const string Player = "Player";
        public const string Enemy = "Enemy";
        public const string Checkpoint = "Checkpoint";
        public const string Interactable = "Interactable";
        public const string Hazard = "Hazard";
    }
    #endregion

    #region Layers (Index & Mask)
    public static class Layers
    {
        // --- Layer Index (0 ~ 31) ---
        public const int Player = 6;
        public const int Enemy = 7;
        public const int PlayerAttack = 8;
        public const int EnemyAttack = 9;
        public const int PlayerProjectile = 10;
        public const int EnemyProjectile = 11;
        public const int Ground = 12;
        public const int OneWayPlatform = 13;
        public const int Hazard = 14;
        public const int Interactable = 15;
        public const int Trigger = 16;

        // --- Layer Names ---
        public const string PlayerName = "Player";
        public const string EnemyName = "Enemy";
        public const string PlayerAttackName = "PlayerAttack";
        public const string EnemyAttackName = "EnemyAttack";
        public const string PlayerProjectileName = "PlayerProjectile";
        public const string EnemyProjectileName = "EnemyProjectile";
        public const string GroundName = "Ground";
        public const string OneWayPlatformName = "OneWayPlatform";
        public const string HazardName = "Hazard";
        public const string InteractableName = "Interactable";
        public const string TriggerName = "Trigger";

        // --- Layer Masks (Bitwise Shift) ---
        public const int PlayerMask = 1 << Player;
        public const int EnemyMask = 1 << Enemy;
        public const int PlayerAttackMask = 1 << PlayerAttack;
        public const int EnemyAttackMask = 1 << EnemyAttack;
        public const int PlayerProjectileMask = 1 << PlayerProjectile;
        public const int EnemyProjectileMask = 1 << EnemyProjectile;
        public const int GroundMask = 1 << Ground;
        public const int OneWayPlatformMask = 1 << OneWayPlatform;
        public const int HazardMask = 1 << Hazard;
        public const int InteractableMask = 1 << Interactable;
        public const int TriggerMask = 1 << Trigger;

        // --- Combined Useful Masks ---
        /// <summary> 바닥 및 통과 가능 발판을 모두 포함하는 마스크 (착지 판정용) </summary>
        public const int GroundAllMask = GroundMask | OneWayPlatformMask;

        /// <summary> 플레이어가 데미지를 입는 공격/투사체/트랩 마스크 </summary>
        public const int EnemyDamageSourceMask = EnemyAttackMask | EnemyProjectileMask | HazardMask;

        /// <summary> 적이 데미지를 입는 공격/투사체 마스크 </summary>
        public const int PlayerDamageSourceMask = PlayerAttackMask | PlayerProjectileMask;
    }
    #endregion

    #region Sorting Layers
    public static class SortingLayers
    {
        public const string Background = "Background";
        public const string EnvironmentBack = "EnvironmentBack";
        public const string Character = "Character";
        public const string Effect = "Effect";
        public const string EnvironmentFront = "EnvironmentFront";
        public const string UI = "UI";

        // Sorting Layer ID (필요 시 내부 ID 상수화)
        public static readonly int BackgroundID = UnityEngine.SortingLayer.NameToID(Background);
        public static readonly int EnvironmentBackID = UnityEngine.SortingLayer.NameToID(EnvironmentBack);
        public static readonly int CharacterID = UnityEngine.SortingLayer.NameToID(Character);
        public static readonly int EffectID = UnityEngine.SortingLayer.NameToID(Effect);
        public static readonly int EnvironmentFrontID = UnityEngine.SortingLayer.NameToID(EnvironmentFront);
        public static readonly int UIID = UnityEngine.SortingLayer.NameToID(UI);
    }
    #endregion
}