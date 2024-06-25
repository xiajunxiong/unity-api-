//创建ISTATE接口
public interface ISTATE
{
    //进入状态
    void Enter();
    //执行状态
    void Execute();
    //退出状态
    void Exit();
}