using XLua;

namespace UnityMMO
{
    [Hotfix]
    [LuaCallCSharp]
    public class GameConst
    {
        public const int RealToLogic = 100;
        // public const int LogicToReal = 1/RealToLogic;
        public const int SpeedFactor = 100;

        //session id split two part:c# side(GamePlay) and lua side(UI)
        public const int MinLuaNetSessionID = System.Int32.MaxValue/2;
        public const int MaxLuaNetSessionID = System.Int32.MaxValue;
        public const int NetResultOk = 0;
        public const int Gravity = -10;
        public const int MaxJumpCount = 3;

        public static string GetRoleResPath()
        {
            return "Assets/AssetBundleRes/role";
        }

        public static string GetUIResPath()
        {
            return "Assets/AssetBundleRes/ui";
        }

        public static string GetRoleCareerResPath(int career)
        {
            return "Assets/AssetBundleRes/role/career_"+career;
        }

        public static string GetMonsterResPath(long typeID)
        {
            return "Assets/AssetBundleRes/monster/monster_"+typeID;
        }

        public static string GetRoleSkillResPath(int career, int skillID)
        {
            return "Assets/AssetBundleRes/role/career_"+career+"/timeline/skill_"+skillID+".playable";
        }

        public static string GetRoleJumpResPath(int career, int jumpID)
        {
            return "Assets/AssetBundleRes/role/career_"+career+"/timeline/jump_"+jumpID+".playable";
        }

    }
}