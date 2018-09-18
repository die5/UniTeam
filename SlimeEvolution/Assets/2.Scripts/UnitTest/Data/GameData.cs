using System.Collections.Generic;
using System;

namespace SlimeEvolution.GameSystem
{
    [Serializable]
    public struct StatData
    {
        public int HealthPoint;
        public int ManaPoint;
        public int SkillPoint;
        public int StrikingPower;
        public int DefensivePower;
        public int Critical;
        public int Experience;
    }

    public struct ItemData
    {
        
    }

    /// <summary>
    /// 작성자 : 박준명
    /// </summary>
    [Serializable]
    public class PlayerData
    {
        public StatData statData;
    }

    /// <summary>
    /// 작성자 : 박준명
    /// </summary>
    [Serializable]
    public class GameData
    {
        public string UserId;
        public string UserPassword;
        public PlayerData PlayerData = new PlayerData();

    }
}

