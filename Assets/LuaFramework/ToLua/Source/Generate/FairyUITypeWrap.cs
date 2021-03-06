﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyUITypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyUIType));
		L.RegVar("None", get_None, null);
		L.RegVar("Normal", get_Normal, null);
		L.RegVar("PopUp", get_PopUp, null);
		L.RegVar("Fixed", get_Fixed, null);
		L.RegVar("Toppest", get_Toppest, null);
		L.RegVar("Waiting", get_Waiting, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<FairyUIType>.Check = CheckType;
		StackTraits<FairyUIType>.Push = Push;
	}

	static void Push(IntPtr L, FairyUIType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyUIType), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, FairyUIType.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Normal(IntPtr L)
	{
		ToLua.Push(L, FairyUIType.Normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PopUp(IntPtr L)
	{
		ToLua.Push(L, FairyUIType.PopUp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Fixed(IntPtr L)
	{
		ToLua.Push(L, FairyUIType.Fixed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Toppest(IntPtr L)
	{
		ToLua.Push(L, FairyUIType.Toppest);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Waiting(IntPtr L)
	{
		ToLua.Push(L, FairyUIType.Waiting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		FairyUIType o = (FairyUIType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

