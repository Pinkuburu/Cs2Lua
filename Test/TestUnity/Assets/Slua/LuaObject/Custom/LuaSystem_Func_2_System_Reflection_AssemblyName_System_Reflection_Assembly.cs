﻿
using System;
using System.Collections.Generic;

namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out System.Func<System.Reflection.AssemblyName,System.Reflection.Assembly> ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,p)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (System.Func<System.Reflection.AssemblyName,System.Reflection.Assembly>)checkObj(l, p);
                return op;
            }
            if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            LuaDelegate ld;
            checkType(l, -1, out ld);
			LuaDLL.lua_pop(l,1);
            if(ld.d!=null)
            {
                ua = (System.Func<System.Reflection.AssemblyName,System.Reflection.Assembly>)ld.d;
                return op;
            }
			
			l = LuaState.get(l).L;
            ua = (System.Reflection.AssemblyName a1) =>
            {
                int error = pushTry(l);

				pushValue(l, a1);
				ld.pcall(1, error);
				System.Reflection.Assembly ret;
				checkType(l,error+1,out ret);
				LuaDLL.lua_settop(l, error-1);
				return ret;
			};
			ld.d=ua;
			return op;
		}
	}
}
