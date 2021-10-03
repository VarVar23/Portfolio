public class Health
    {
        private int MaxHp;
        private int MixHp;
        private int CurrenHp;

        public int PlayerHealth
        {
            get
            {
                if (CurrenHp == MixHp)
                {
                    //GameObject.Destroy();
                }
                return CurrenHp;
                
            }
            set
            {
                if (MaxHp != 0)
                {
                    MaxHp = value;
                }
            }
        }

        public Health(int maxHp, int min, int currenHp)
        {
            MaxHp = maxHp;
            MixHp = min;
            CurrenHp = currenHp;
        }
    }
