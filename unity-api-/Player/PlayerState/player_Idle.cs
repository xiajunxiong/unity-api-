    using UnityEngine;

    public class Player_Idle : ISTATE
    {
        private player _player;

        public Player_Idle(player _player)
        {
            this.player = _player;
        }

        public void Enter()
        {
            //进入状态要做的操作
        }

        public void Execute()
        {
            //执行状态要做的操作
            //切换状态
            int a = 1;
            if(a == 1){
                _player.ChangeState(PlayerState.Run);

            }
        }

        public void Exit()
        {
            //退出状态要做的操作
        }
    }