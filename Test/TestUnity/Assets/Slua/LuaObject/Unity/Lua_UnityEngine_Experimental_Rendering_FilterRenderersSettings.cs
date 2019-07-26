﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_FilterRenderersSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Rendering.FilterRenderersSettings o;
			if(argc==2){
				System.Boolean a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Experimental.Rendering.FilterRenderersSettings(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new UnityEngine.Experimental.Rendering.FilterRenderersSettings();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderQueueRange(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderQueueRange);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderQueueRange(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderQueueRange v;
			checkValueType(l,2,out v);
			self.renderQueueRange=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.layerMask=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderingLayerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderingLayerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderingLayerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			System.UInt32 v;
			checkType(l,2,out v);
			self.renderingLayerMask=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_excludeMotionVectorObjects(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.excludeMotionVectorObjects);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_excludeMotionVectorObjects(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.FilterRenderersSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.excludeMotionVectorObjects=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.FilterRenderersSettings");
		addMember(l,"renderQueueRange",get_renderQueueRange,set_renderQueueRange,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		addMember(l,"renderingLayerMask",get_renderingLayerMask,set_renderingLayerMask,true);
		addMember(l,"excludeMotionVectorObjects",get_excludeMotionVectorObjects,set_excludeMotionVectorObjects,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.FilterRenderersSettings),typeof(System.ValueType));
	}
}
