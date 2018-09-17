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
        public string Name = "Jun";
        public int Level = 1;
        public int Hp = 50;
        public int Mp = 30;
        public int AD = 15;
        public int DEF = 4;
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

