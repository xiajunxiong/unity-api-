using UnityEngine;
/// <summary>
/// 创建状态枚举
/// </summary>
public enum PlayerState{
    Idle,
    Run,
    Die
}
public class player : MonoBehaviour
{
    public ISTATE currentState;
    //创建状态字典
    public Dictionary<PlayerState,ISTATE> stateDic = new Dictionary<PlayerState, ISTATE>();
    void Start(){
        //添加状态
        stateDic.Add(PlayerState.Idle,new Player_Idle(this));
        stateDic.Add(PlayerState.Run,new Player_Run(this));
        stateDic.Add(PlayerState.Die,new Player_Die(this));
        //初始状态
        currentState = stateDic[PlayerState.Idle];
    }
    void Update(){
        //执行状态
        if(currentState != null){
            currentState.Execute();
        }
    }
    //切换状态
    public void ChangeState(PlayerState state){
        if(currentState != null){
            currentState.Exit();
        }
        currentState = stateDic[state];
        currentState.Enter();
    }
}
