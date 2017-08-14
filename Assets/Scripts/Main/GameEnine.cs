﻿

public class GameEnine : XObject
{

    private static GameEntrance _entrance;

    public static void Init(GameEntrance en)
    {
        _entrance = en;

        ABManager.singleton.Init(_entrance);
        Documents.singleton.Initial();
        UIManager.singleton.Initial();
    }




    public static void Update(float delta)
    {
        //xtouch must be update first
        XTouch.singleton.Update(delta);

        XResourceMgr.Update();
        XEntityMgr.singleton.Update(delta);
    }


    public static void LateUpdate()
    {
        XEntityMgr.singleton.LateUpdate();
    }

    public static void OnUnintial()
    {

    }

}