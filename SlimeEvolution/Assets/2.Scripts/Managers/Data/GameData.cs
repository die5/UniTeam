using System.Collections.Generic;
using System;

namespace SlimeEvolution.GameSystem
{
    /// <summary>
    /// 작성자 : 박준명
    /// </summary>
    [Serializable]
    public class PlayerData
    {
        string Name = "Jun";
        int Level = 1;
        int Hp = 50;
        int Mp = 30;
        int AD = 15;
        int DEF = 4;
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

